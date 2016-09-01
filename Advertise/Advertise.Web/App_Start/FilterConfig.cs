using System.Web.Mvc;
using Advertise.Common.Filters;

namespace Advertise.Web
{
    /// <summary>
    /// </summary>
    public static class FilterConfig
    {
        /// <summary>
        /// </summary>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // logg action errors
            filters.Add(new ElmahHandledErrorLoggerFilter());

            //  logg xss attacks
            filters.Add(new ElmahRequestValidationErrorFilter());

            //
            filters.Add(new RemoveServerHeaderFilterAttribute());

            //
            //filters.Add(new ForceWwwAttribute("http://localhost:25890/"));
        }
    }
}