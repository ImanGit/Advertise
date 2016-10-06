using System.Web.Mvc;
using System.Web.Routing;

namespace Advertise.Web
{
    /// <summary>
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            #region IgnoreRoutes

            routes.IgnoreRoute("Content/{*pathInfo}");
            routes.IgnoreRoute("Scripts/{*pathInfo}");
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("favicon.ico");
            routes.IgnoreRoute("{resource}.ico");
            routes.IgnoreRoute("{resource}.png");
            routes.IgnoreRoute("{resource}.jpg");
            routes.IgnoreRoute("{resource}.gif");
            routes.IgnoreRoute("{resource}.txt");
            routes.IgnoreRoute("elmah.axd");

            #endregion

            routes.LowercaseUrls = true;
            //routes.MapMvcAttributeRoutes();
            //AreaRegistration.RegisterAllAreas();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = MVC.Home.Name , action = MVC.Home.ActionNames.Index , id = UrlParameter.Optional }
            );

            //routes.MapRoute("Default", "{controller}/{action}/{id}",
            //    new {controller = MVC.Home.Name, action = MVC.Home.ActionNames.Index, id = UrlParameter.Optional},
            //    new[] {$"{typeof (RouteConfig).Namespace}.Controllers"}
            //    );
        }
    }
}