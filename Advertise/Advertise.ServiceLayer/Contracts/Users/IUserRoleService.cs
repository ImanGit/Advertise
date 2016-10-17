using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using Advertise.DomainClasses.Entities.Roles;
using Advertise.DomainClasses.Entities.Users;
using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.UserRoles;
using Microsoft.AspNet.Identity;

namespace Advertise.ServiceLayer.Contracts.Users
{
    /// <summary>
    /// </summary>
    public interface IUserRoleService : IBaseService, IDisposable
    {
        #region AspNetIdentityMethods

        /// <summary>
        ///     Used to validate roles before persisting changes
        /// </summary>
        IIdentityValidator<Role> RoleValidator { get; set; }

        /// <summary>
        /// </summary>
        bool AutoCommitEnabled { get; set; }

        /// <summary>
        ///     Create a role
        /// </summary>
        /// <param name="role" />
        /// <returns />
        Task<IdentityResult> CreateAsync(Role role);

        /// <summary>
        ///     Update an existing role
        /// </summary>
        /// <param name="role" />
        /// <returns />
        Task<IdentityResult> UpdateAsync(Role role);

        /// <summary>
        ///     Delete a role
        /// </summary>
        /// <param name="role" />
        /// <returns />
        Task<IdentityResult> DeleteAsync(Role role);

        /// <summary>
        ///     Returns true if the role exists
        /// </summary>
        /// <param name="roleName" />
        /// <returns />
        Task<bool> RoleExistsAsync(string roleName);

        /// <summary>
        ///     Find a role by id
        /// </summary>
        /// <param name="roleId" />
        /// <returns />
        Task<Role> FindByIdAsync(Guid roleId);

        /// <summary>
        ///     Find a role by name
        /// </summary>
        /// <param name="roleName" />
        /// <returns />
        Task<Role> FindByNameAsync(string roleName);

        #endregion

        #region OurNewCustomMethods

        /// <summary>
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Role FindRoleByName(string roleName);

        /// <summary>
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        IdentityResult CreateRole(Role role);

        /// <summary>
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        IList<UserRole> GetUsersOfRole(string roleName);

        /// <summary>
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        IList<User> GetApplicationUsersInRole(string roleName);

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        IList<string> FindUserRoles(Guid userId);

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        string[] GetRolesForUser(Guid userId);

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        bool IsUserInRole(Guid userId, string roleName);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<IList<Role>> GetAllRolesAsync();

        /// <summary>
        /// </summary>
        void SeedDatabase();

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task RemoteAll();

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<UserRoleViewModel>> GetList();

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        Task<UserRoleViewModel> AddRole(UserRoleCreateViewModel viewModel);

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        Task<bool> EditRole(UserRoleEditViewModel viewModel);

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<UserRoleEditViewModel> GetRoleByPermissionsAsync(Guid id);

        /// <summary>
        /// </summary>
        /// <param name="roles"></param>
        void AddRange(IEnumerable<Role> roles);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<bool> AnyAsync();

        /// <summary>
        /// </summary>
        /// <returns></returns>
        bool Any();

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        bool CheckForExisByName(string name, Guid? id);

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task RemoveById(Guid id);

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> CheckRoleIsSystemRoleAsync(Guid id);

        /// <summary>
        ///     واکشی لیست گروه ها کاربری
        /// </summary>
        /// <returns></returns>
        Task<UserRoleListViewModel> GetPageList(UserRoleFindViewModel request);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<SelectListItem>> GetAllAsSelectList();

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        IEnumerable<Guid> FindUserRoleIds(Guid userId);

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<IList<string>> FindUserPermissions(Guid userId);

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<IList<Guid>> FindUserRoleIdsAsync(Guid userId);

        /// <summary>
        ///     چک کردن برای موچود بود در دیتابیس
        /// </summary>
        /// <param name="id">آی دی</param>
        /// <returns></returns>
        Task<bool> IsInDb(Guid id);

        /// <summary>
        ///     پر کردن لیست های مربوطه
        /// </summary>
        /// <returns></returns>
        void FillForEdit(UserRoleEditViewModel viewModel);

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<UserRoleViewModel> GetRole(Guid id);

        #endregion
    }
}