using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Roles;
using Advertise.DomainClasses.Entities.Users;
using Advertise.ServiceLayer.Contracts.Users;
using Advertise.ServiceLayer.CustomAspNetIdentity;
using Advertise.ServiceLayer.Security;
using Advertise.Utility.Extensions;
using Advertise.Utility.Normalizations;
using Advertise.ViewModel.Models.Users;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using EFSecondLevelCache;
using EFSecondLevelCache.Contracts;
using EntityFramework.Extensions;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.DataProtection;
using RefactorThis.GraphDiff;

namespace Advertise.ServiceLayer.EFServices.Users
{
    /// <summary>
    /// </summary>
    public class UserService : UserManager<User, Guid>, IUserService
    {
        #region Ctor

        /// <summary>
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        /// <param name="applicationPermissionService"></param>
        /// <param name="userRoleService"></param>
        /// <param name="userStore"></param>
        /// <param name="identity"></param>
        /// <param name="dataProtectionProvider"></param>
        /// <param name="smsService"></param>
        /// <param name="emailService"></param>
        public UserService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IApplicationPermissionService applicationPermissionService,
            IUserRoleService userRoleService,
            IUserStore<User, Guid> userStore,
            IIdentity identity,
            IDataProtectionProvider dataProtectionProvider,
            IIdentityMessageService smsService,
            IIdentityMessageService emailService) : base(userStore)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _applicationPermissionService = applicationPermissionService;
            _userRoleService = userRoleService;
            _users = _unitOfWork.Set<User>();
            _identity = identity;
            _dataProtectionProvider = dataProtectionProvider;
            SmsService = smsService;
            EmailService = emailService;
            AutoCommitEnabled = true;
            CreateApplicationUserManager();
        }

        #endregion

        #region GenerateUserIdentityAsync

        /// <summary>
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(User user)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here

            return userIdentity;
        }

        #endregion

        #region HasPassword

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<bool> HasPassword(Guid userId)
        {
            var user = await FindByIdAsync(userId);
            return user?.PasswordHash != null;
        }

        #endregion

        #region HasPhoneNumber

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<bool> HasPhoneNumber(Guid userId)
        {
            var user = await FindByIdAsync(userId);
            return user?.PhoneNumber != null;
        }

        #endregion

        #region OnValidateIdentity

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public Func<CookieValidateIdentityContext, Task> OnValidateIdentity()
        {
            return CustomSecurityStampValidator.OnValidateIdentity(TimeSpan.FromMinutes(0), GenerateUserIdentityAsync,
                identity => Guid.Parse(identity.GetUserId()));
        }

        #endregion

        #region SeedDatabase

        /// <summary>
        /// </summary>
        public void SeedDatabase()
        {
            const string systemAdminUserName = "Admin";
            const string systemAdminPassword = "AdminPassword";
            const string systemAdminEmail = "Info@Admin.com";
            const string systemAdminDisplayName = "مدیر سیستم";

            var user = _users.FirstOrDefault(a => a.IsSystemAccount);
            if (user == null)
            {
                user = new User
                {
                    DisplayName = systemAdminDisplayName,
                    UserName = systemAdminUserName,
                    IsSystemAccount = true,
                    Email = systemAdminEmail.FixEmailDots()
                };
                this.Create(user, systemAdminPassword);
                this.SetLockoutEnabled(user.Id, false);
            }

            var userRoles = _userRoleService.FindUserRoles(user.Id);
            if (userRoles.Any(a => a == StandardRoles.Administrators)) return;
            this.AddToRole(user.Id, StandardRoles.Administrators);
        }

        #endregion

        #region GetAllUsersAsync

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public Task<List<User>> GetAllUsersAsync()
        {
            return Users.ToListAsync();
        }

        #endregion

        #region DeleteAll

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public async Task RemoveAll()
        {
            await Users.DeleteAsync();
        }

        #endregion

        #region GetUsersWithRoleIds

        /// <summary>
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public IList<User> GetUsersWithRoleIds(params Guid[] ids)
        {
            return Users.Where(applicationUser => ids.Contains(applicationUser.Id)).ToList();
        }

        #endregion

        #region AutoCommitEnabled

        /// <summary>
        /// </summary>
        public bool AutoCommitEnabled { get; set; }

        #endregion

        #region Any

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public bool Any()
        {
            return _users.Any();
        }

        #endregion

        #region AddRange

        /// <summary>
        /// </summary>
        /// <param name="users"></param>
        public void AddRange(IEnumerable<User> users)
        {
            _unitOfWork.AddThisRange(users);
        }

        #endregion

        #region GetPageList

        /// <summary>
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public async Task<UserListViewModel> GetPageList(UserSearchRequest search)
        {
            var users = _users.AsNoTracking().OrderBy(a => a.UserName).AsQueryable();

            if (search.RoleId.HasValue)
            {
                users =
                    users.Include(a => a.Roles)
                        .Where(a => a.Roles.Any(r => r.RoleId == search.RoleId.Value))
                        .AsQueryable();
            }

            if (search.UserName.HasValue())
                users = users.Where(a => a.UserName.Contains(search.UserName));

            var query = await users
                .Skip((search.PageIndex - 1)*10).Take(10).ProjectTo<UserViewModel>(_mapper)
                .ToListAsync();

            return new UserListViewModel
            {
                SearchRequest = search,
                Users = query
            };
        }

        #endregion

        #region GetForEditAsync

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<UserEditViewModel> GetForEditAsync(Guid id)
        {
            var userWithRoles = await
                _users.AsNoTracking()
                    .Include(a => a.Roles)
                    .FirstOrDefaultAsync(a => a.Id == id);
            if (userWithRoles == null) return null;
            var viewModel = _mapper.Map<UserEditViewModel>(userWithRoles);
            viewModel.Roles = await _userRoleService.GetAllAsSelectList();
            if (userWithRoles.Roles != null && userWithRoles.Roles.Any())
                viewModel.Roles.ToList()
                    .ForEach(a => a.Selected = userWithRoles.Roles.First().RoleId.ToString() == a.Value);
            return viewModel;
        }

        #endregion

        #region EditUser

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public async Task<UserViewModel> EditUser(UserEditViewModel viewModel)
        {
            var user = _users.Find(viewModel.Id);
            _mapper.Map(viewModel, user);
            if (viewModel.Password.IsNotEmpty())
            {
                user.PasswordHash = PasswordHasher.HashPassword(viewModel.Password);
            }

            if (viewModel.RoleId.HasValue)
            {
                _unitOfWork.MarkAsDetached(user);
                user.Roles.Add(new UserRole {RoleId = viewModel.RoleId.Value, UserId = user.Id});
                _unitOfWork.Update(user, a => a.AssociatedCollection(u => u.Roles));
            }
            {
                user.Roles.Clear();
            }

            if (!await IsInRoleAsync(user.Id, StandardRoles.Administrators))
                this.UpdateSecurityStamp(user.Id);
            else await _unitOfWork.SaveAllChangesAsync();

            return await GetUserViewModel(viewModel.Id);
        }

        #endregion

        #region SetRolesToUser

        /// <summary>
        /// </summary>
        /// <param name="user"></param>
        /// <param name="roles"></param>
        public void SetRolesToUser(User user, IEnumerable<Role> roles)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region AddUser

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public async Task<UserViewModel> AddUser(UserCreateViewModel viewModel)
        {
            var user = _mapper.Map<User>(viewModel);
            user.Email = AspNetIdentityRequiredEmail;
            await CreateAsync(user, viewModel.Password);
            return await GetUserViewModel(user.Id);
        }

        #endregion

        #region CustomValidatePasswordAsync

        /// <summary>
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public async Task<string> CustomValidatePasswordAsync(string pass)
        {
            var result = await PasswordValidator.ValidateAsync(pass);
            return result.Errors.GetUserManagerErros();
        }

        #endregion

        #region GetEmailStore

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public IUserEmailStore<User, Guid> GetEmailStore()
        {
            var cast = Store as IUserEmailStore<User, Guid>;
            if (cast == null)
            {
                throw new NotSupportedException("not support");
            }
            return cast;
        }

        #endregion

        #region IsEmailAvailableForConfirm

        /// <summary>
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool IsEmailAvailableForConfirm(string email)
        {
            email = email.FixEmailDots();
            return _users.Any(a => a.Email == email);
        }

        #endregion

        #region EditSecurityStamp

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        public void EditSecurityStamp(Guid userId)
        {
            this.UpdateSecurityStamp(userId);
        }

        #endregion

        #region FindUserById

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User FindUserById(Guid id)
        {
            return this.FindById(id);
        }

        #endregion

        #region IsInDb

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<bool> IsInDb(Guid id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Fill

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public async Task FillForEdit(UserEditViewModel viewModel)
        {
            viewModel.Roles = await _userRoleService.GetAllAsSelectList();
            if (viewModel.RoleId.HasValue)
            {
                viewModel.Roles.ToList().ForEach(a => a.Selected = viewModel.RoleId.Value.ToString() == a.Value);
            }
        }

        #endregion

        #region DeleteAsync

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task DeleteAsync(Guid id)
        {
            return _users.Where(a => a.Id == id).DeleteAsync();
        }

        #endregion

        #region IsSystemUser

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<bool> IsSystemUser(Guid id)
        {
            return _users.AnyAsync(a => a.Id == id && a.IsSystemAccount);
        }

        #endregion

        #region Ban

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public async Task<UserViewModel> Ban(Guid id, bool flag)
        {
            var user = _users.Find(id);
            user.IsBan = flag;
            await UpdateSecurityStampAsync(id);
            return await GetUserViewModel(user.Id);
        }

        #endregion

        #region GetUserViewModel

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<UserViewModel> GetUserViewModel(Guid id)
        {
            return _users.AsNoTracking().ProjectTo<UserViewModel>(_mapper).FirstOrDefaultAsync(a => a.Id == id);
        }

        #endregion

        #region GetAsSelectListItem

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<SelectListItem>> GetAsSelectListItem()
        {
            var currentUserId = GetCurrentUserId();
            return await _users.Where(a => a.Id != currentUserId).ProjectTo<SelectListItem>(_mapper)
                .Cacheable(new EFCachePolicy {AbsoluteExpiration = DateTime.Now.AddDays(1)}).ToListAsync();
        }

        #endregion

        #region Count

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public long Count()
        {
            return _users.LongCount();
        }

        #endregion

        #region GenerateUserIdentityAsync

        /// <summary>
        /// </summary>
        /// <param name="service"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        private static async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserService service, User user)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await service.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here

            return userIdentity;
        }

        #endregion

        #region CreateApplicationUserManager

        /// <summary>
        /// </summary>
        private void CreateApplicationUserManager()
        {
            ClaimsIdentityFactory = new CustomClaimsIdentityFactory();

            UserValidator = new CustomUserValidator<User, Guid>(this)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = false
            };

            PasswordValidator = new CustomPasswordValidator
            {
                RequiredLength = 5,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false
            };

            UserLockoutEnabledByDefault = true;
            DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            MaxFailedAccessAttemptsBeforeLockout = 5;

            if (_dataProtectionProvider == null) return;

            var dataProtector = _dataProtectionProvider.Create("Asp.net Identity");
            UserTokenProvider = new DataProtectorTokenProvider<User, Guid>(dataProtector);
        }

        #endregion

        #region EditIsChangedPermissionsField

        /// <summary>
        /// </summary>
        public void EditIsChangedPermissionsField()
        {
            _unitOfWork.SaveChanges();
        }

        #endregion

        #region Fields

        private const string AspNetIdentityRequiredEmail = "email@example.com";
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IApplicationPermissionService _applicationPermissionService;
        private readonly IUserRoleService _userRoleService;
        private readonly IDbSet<User> _users;
        private User _user;
        private readonly IIdentity _identity;
        private readonly IDataProtectionProvider _dataProtectionProvider;

        #endregion

        #region Validations

        /// <summary>
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckUserNameExist(string userName, Guid? id)
        {
            var users = _users.Select(a => new {a.Id, a.UserName}).ToList();
            return id == null
                ? users.Any(a => string.Equals(a.UserName, userName, StringComparison.InvariantCultureIgnoreCase))
                : users.Any(
                    a =>
                        string.Equals(a.UserName, userName, StringComparison.InvariantCultureIgnoreCase) &&
                        a.Id != id.Value);
        }

        /// <summary>
        /// </summary>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckEmailExist(string email, Guid? id)
        {
            email = email.FixEmailDots();
            return id == null
                ? _users.Any(a => a.Email == email.ToLower())
                : _users.Any(a => a.Email == email.ToLower() && a.Id != id.Value);
        }

        /// <summary>
        /// </summary>
        /// <param name="nameForShow"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckNameForShowExist(string nameForShow, Guid? id)
        {
            throw new NotImplementedException();
            //var namesForShow = _users.Select(a => new { Name = a.NameForShow, a.Id }).ToList();
            //nameForShow = nameForShow.GetFriendlyPersianName();
            //return id == null
            // ? namesForShow.Any(a => a.Name.GetFriendlyPersianName() == nameForShow)
            // : namesForShow.Any(a => a.Name.GetFriendlyPersianName() == nameForShow && a.Id != id.Value);
        }

        /// <summary>
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckPhoneNumberExist(string phoneNumber, Guid? id)
        {
            return id == null
                ? _users.Any(a => a.PhoneNumber == phoneNumber)
                : _users.Any(a => a.PhoneNumber == phoneNumber && a.Id != id.Value);
        }

        #endregion

        #region override GetRolesAsync

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public override async Task<IList<string>> GetRolesAsync(Guid userId)
        {
            var userPermissions = await _userRoleService.FindUserPermissions(userId);
            ////todo: any permission form other sections
            return userPermissions;
        }

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool ShouldRefreshPermissions(Guid userId)
        {
            var user = _users.Find(userId);
            return user.IsChangePermission || user.IsBan;
        }

        #endregion

        #region ChechIsBanneduser

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckIsUserBanned(Guid id)
        {
            return _users.Any(a => a.Id == id && a.IsBan);
        }

        /// <summary>
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool CheckIsUserBanned(string userName)
        {
            return _users.Any(a => a.UserName == userName.ToLower() && a.IsBan);
        }

        /// <summary>
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool CheckIsUserBannedByEmail(string email)
        {
            return _users.Any(a => a.Email == email.FixEmailDots() && a.IsBan);
        }

        #endregion

        #region Private

        /// <summary>
        /// </summary>
        /// <param name="dependencies"></param>
        /// <returns></returns>
        private static string[] SplitString(string dependencies)
        {
            if (dependencies == null) return new string[0];
            var split = from dependency in dependencies.Split(',')
                let lowerDependency = dependency.ToLower()
                where !string.IsNullOrEmpty(lowerDependency)
                select lowerDependency;
            return split.ToArray();
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        private bool IsExistOneSystemAccount()
        {
            return _users.Any(a => a.IsSystemAccount);
        }

        #endregion

        #region CurrentUser

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public User GetCurrentUser()
        {
            return _user ?? (_user = this.FindById(GetCurrentUserId()));
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public async Task<User> GetCurrentUserAsync()
        {
            return _user ?? (_user = await FindByIdAsync(GetCurrentUserId()));
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public Guid GetCurrentUserId()
        {
            return Guid.Parse(HttpContext.Current.User.Identity.GetUserId());
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public bool IsAdministrator()
        {
            return HttpContext.Current.User.IsInRole(StandardRoles.Administrators);
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public bool IsOperator()
        {
            return HttpContext.Current.User.IsInRole(StandardRoles.Operators);
        }

        #endregion
    }
}