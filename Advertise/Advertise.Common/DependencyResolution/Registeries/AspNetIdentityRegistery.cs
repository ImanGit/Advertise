using System;
using System.Data.Entity;
using System.Web;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Roles;
using Advertise.DomainClasses.Entities.Users;
using Advertise.ServiceLayer.Contracts.Roles;
using Advertise.ServiceLayer.Contracts.Users;
using Advertise.ServiceLayer.EFServices;
using Advertise.ServiceLayer.EFServices.Users;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using StructureMap;
using StructureMap.Web;

namespace Advertise.Common.DependencyResolution.Registeries
{
    /// <summary>
    /// </summary>
    public class AspNetIdentityRegistery : Registry
    {
        /// <summary>
        /// </summary>
        public AspNetIdentityRegistery()
        {
            For<ApplicationDbContext>()
                .HybridHttpOrThreadLocalScoped()
                .Use(context => (ApplicationDbContext) context.GetInstance<IUnitOfWork>());

            For<DbContext>()
                .HybridHttpOrThreadLocalScoped()
                .Use(context => (ApplicationDbContext) context.GetInstance<IUnitOfWork>());

            For<IUserStore<User, Guid>>()
                .HybridHttpOrThreadLocalScoped()
                .Use<UserStore<User, Role, Guid, UserLogin, UserRole, UserClaim>>();

            For<IRoleStore<Role, Guid>>().HybridHttpOrThreadLocalScoped().Use<RoleStore<Role, Guid, UserRole>>();

            For<IAuthenticationManager>().Use(() => HttpContext.Current.GetOwinContext().Authentication);

            For<IApplicationSignInManagerService>()
                .HybridHttpOrThreadLocalScoped()
                .Use<ApplicationSignInManagerService>();

            For<IRoleService>().HybridHttpOrThreadLocalScoped().Use<IRoleService>();

            For<IIdentityMessageService>().Use<SmsService>();

            For<IIdentityMessageService>().Use<EmailService>();

            For<IUserService>().HybridHttpOrThreadLocalScoped().Use<UserService>()
                .Ctor<IIdentityMessageService>("smsService").Is<SmsService>()
                .Ctor<IIdentityMessageService>("emailService").Is<EmailService>()
                .Setter(userService => userService.SmsService).Is<SmsService>()
                .Setter(userService => userService.EmailService).Is<EmailService>();

            For<UserService>()
                .HybridHttpOrThreadLocalScoped()
                .Use(context => (UserService) context.GetInstance<IUserService>());

            For<IApplicationRoleStoreService>().HybridHttpOrThreadLocalScoped().Use<ApplicationRoleStoreService>();

            For<IApplicationUserStoreService>().HybridHttpOrThreadLocalScoped().Use<ApplicationUserStoreService>();
        }
    }
}