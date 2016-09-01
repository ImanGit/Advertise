using System;
using Advertise.DomainClasses.Entities.Users;
using Advertise.ServiceLayer.Contracts.Users;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Advertise.ServiceLayer.EFServices.Users
{
    /// <summary>
    /// </summary>
    public class ApplicationSignInManagerService : SignInManager<User, Guid>, IApplicationSignInManagerService
    {
        #region Constructor

        /// <summary>
        /// </summary>
        /// <param name="userService"></param>
        /// <param name="authenticationManager"></param>
        public ApplicationSignInManagerService(UserService userService, IAuthenticationManager authenticationManager)
            : base(userService, authenticationManager)
        {
            _userService = userService;
            _authenticationManager = authenticationManager;
        }

        #endregion

        #region Fields

        private readonly UserService _userService;
        private readonly IAuthenticationManager _authenticationManager;

        #endregion
    }
}