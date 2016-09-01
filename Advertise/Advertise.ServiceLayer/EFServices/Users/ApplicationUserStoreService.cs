using System;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Roles;
using Advertise.DomainClasses.Entities.Users;
using Advertise.ServiceLayer.Contracts.Users;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Advertise.ServiceLayer.EFServices.Users
{
    /// <summary>
    /// </summary>
    public class ApplicationUserStoreService : UserStore<User, Role, Guid, UserLogin, UserRole, UserClaim>,
        IApplicationUserStoreService
    {
        /// <summary>
        /// </summary>
        /// <param name="dbContext"></param>
        public ApplicationUserStoreService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}