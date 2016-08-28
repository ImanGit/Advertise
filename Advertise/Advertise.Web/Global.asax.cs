using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Advertise.Web
{
    /// <summary>
    /// </summary>
    public class MvcApplication : HttpApplication
    {
        /// <summary>
        /// </summary>
        protected void Application_Start()
        {
            try
            {
                Startup.Configuration();
                AreaRegistration.RegisterAllAreas();
                RouteConfig.RegisterRoutes(RouteTable.Routes);
                BundleConfig.RegisterBundles(BundleTable.Bundles);
                FilterConfig.RegisterGlobalFilters();
                EntityFrameworkConfig.RegisterEntityFramework();
                StructureMapConfig.RegisterStructureMap();
                AutoMapperConfig.RegisterAutoMapper();
                AspNetIdentityConfig.RegisterAspNetIdentity();
            }
            catch
            {
                // سبب ری استارت برنامه و آغاز مجدد آن با درخواست بعدی می‌شود
                HttpRuntime.UnloadAppDomain();
                throw;
            }
        }
    }
}