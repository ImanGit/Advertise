using System.Web.Optimization;

namespace Advertise.Web
{
    /// <summary>
    /// 
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bundles"></param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Content/iransans.css", "~/Content/bootstrap.css", "~/Content/font-awesome.css",
                    "~/Content/Site.css"));



            BundleTable.EnableOptimizations = true;
        }
    }
}
