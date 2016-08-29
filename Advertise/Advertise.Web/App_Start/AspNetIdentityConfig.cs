using System;
using Advertise.Common.DependencyResolution;
using Advertise.ServiceLayer.Contracts.Roles;
using Advertise.ServiceLayer.Contracts.Users;
using Advertise.ServiceLayer.EFServices.Users;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.DataProtection;
using Owin;
using StructureMap.Web;

namespace Advertise.Web
{
    /// <summary>
    /// </summary>
    public class AspNetIdentityConfig
    {
        /// <summary>
        /// </summary>
        public static void RegisterAspNetIdentity(IAppBuilder appBuilder)
        {
            const int twoWeeks = 14;

            ApplicationObjectFactory.Container.Configure(
                config =>
                    config.For<IDataProtectionProvider>()
                        .HybridHttpOrThreadLocalScoped()
                        .Use(() => appBuilder.GetDataProtectionProvider()));

            appBuilder.CreatePerOwinContext(() => ApplicationObjectFactory.Container.GetInstance<UserService>());

            appBuilder.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                ExpireTimeSpan = TimeSpan.FromDays(twoWeeks),
                SlidingExpiration = true,
                CookieName = "advertise",
                Provider = new CookieAuthenticationProvider
                {
                    OnValidateIdentity =
                        ApplicationObjectFactory.Container.GetInstance<IUserService>().OnValidateIdentity()
                }
            });

            ApplicationObjectFactory.Container.GetInstance<IRoleService>().SeedDatabase();

            ApplicationObjectFactory.Container.GetInstance<IUserService>().SeedDatabase();
        }
    }
}