using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Advertise.Common.DependencyResolution;
using Advertise.ServiceLayer.Contracts.Common;
using StructureMap.Web.Pipeline;

namespace Advertise.Web
{
    /// <summary>
    /// </summary>
    public class MvcApplication : HttpApplication
    {
        #region Application_Start

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
                FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
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

        #endregion

        #region Application_Error

        /// <summary>
        /// </summary>
        protected void Application_Error()
        {
            foreach (var task in ApplicationObjectFactory.Container.GetAllInstances<IRunOnErrorService>())
            {
                task.Execute();
            }
        }

        #endregion

        #region Application_BeginRequest

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_BeginRequest(object sender, EventArgs e)
        {
            foreach (var task in ApplicationObjectFactory.Container.GetAllInstances<IRunOnEachRequestService>())
            {
                task.Execute();
            }
        }

        #endregion

        #region Application_EndRequest

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_EndRequest(object sender, EventArgs e)
        {
            try
            {
                foreach (var task in ApplicationObjectFactory.Container.GetAllInstances<IRunAfterEachRequestService>())
                {
                    task.Execute();
                }
            }
            catch (Exception)
            {
                HttpContextLifecycle.DisposeAndClearAll();
            }
        }

        #endregion

        #region ShouldIgnoreRequest

        /// <summary>
        /// </summary>
        /// <returns></returns>
        private bool ShouldIgnoreRequest()
        {
            string[] reservedPath =
            {
                "/__browserLink",
                "/Scripts",
                "/Content"
            };

            var rawUrl = Context.Request.RawUrl;
            if (reservedPath.Any(path => rawUrl.StartsWith(path, StringComparison.OrdinalIgnoreCase)))
            {
                return true;
            }

            return
                BundleTable.Bundles.Select(bundle => bundle.Path.TrimStart('~'))
                    .Any(bundlePath => rawUrl.StartsWith(bundlePath, StringComparison.OrdinalIgnoreCase));
        }

        #endregion

        #region Private

        /// <summary>
        /// </summary>
        /// <param name="permissions"></param>
        private void SetPermissions(IEnumerable<string> permissions)
        {
            Context.User = new GenericPrincipal(Context.User.Identity, permissions.ToArray());
        }

        #endregion
    }
}