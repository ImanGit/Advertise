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
        public static void RegisterAspNetIdentity()
        {
        }

        /// <summary>
        ///     For OWIN Config
        /// </summary>
        public static void Configuration(IAppBuilder appBuilder)
        {
            const int twoWeeks = 14;

            StructureMapObjectFactory.Container.Configure(
                config =>
                    config.For<IDataProtectionProvider>()
                        .HybridHttpOrThreadLocalScoped()
                        .Use(() => appBuilder.GetDataProtectionProvider()));

            appBuilder.CreatePerOwinContext(() => StructureMapObjectFactory.Container.GetInstance<UserService>());

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
                        StructureMapObjectFactory.Container.GetInstance<IUserService>().OnValidateIdentity()
                }
            });

            StructureMapObjectFactory.Container.GetInstance<IRoleService>().SeedDatabase();

            StructureMapObjectFactory.Container.GetInstance<IUserService>().SeedDatabase();
        }
    }
}