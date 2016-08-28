using System;
using Advertise.DomainClasses.Entities.Roles;
using Advertise.ServiceLayer.Contracts.Users;
using Microsoft.AspNet.Identity;

namespace Advertise.ServiceLayer.EFServices.Users
{
    /// <summary>
    /// </summary>
    public class ApplicationRoleStoreService : IApplicationRoleStoreService
    {
        private readonly IRoleStore<Role, Guid> _roleStore;

        /// <summary>
        /// </summary>
        /// <param name="roleStore"></param>
        public ApplicationRoleStoreService(IRoleStore<Role, Guid> roleStore)
        {
            _roleStore = roleStore;
        }
    }
}