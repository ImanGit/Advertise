using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Users;
using Advertise.ServiceLayer.Contracts.Users;
using Advertise.ServiceLayer.CustomAspNetIdentity;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;

namespace Advertise.ServiceLayer.EFServices.Users
{
    /// <summary>
    /// </summary>
    public class UserService : UserManager<User, Guid>, IUserService
    {
        #region Ctor

        public UserService(IUnitOfWork unitOfWork, IUserStore<User, Guid> userStore) : base(userStore)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion

        #region Create

        /// <summary>
        /// </summary>
        public void Create()
        {
        }

        #endregion

        #region Update

        public void Edit()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region SeedDatabase

        public void SeedDatabase()
        {
            //throw new NotImplementedException();
        }

        #endregion

        #region Retrive

        public void Get()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Count

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public long GetCount()
        {
            return 0;
        }

        #endregion

        #region Delete

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Func<CookieValidateIdentityContext, Task> OnValidateIdentity()
        {
            return CustomSecurityStampValidator.OnValidateIdentity(TimeSpan.FromMinutes(0), GenerateUserIdentityAsync,
                identity => Guid.Parse(identity.GetUserId()));
        }

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

        /// <summary>
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        private static async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserService manager, User user)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here

            return userIdentity;
        }

        #endregion

        #region Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<User> _users;

        #endregion
    }
}