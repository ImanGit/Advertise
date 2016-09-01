using System.Collections.Generic;
using System.Web.Optimization;

namespace Advertise.Web
{
    /// <summary>
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        ///     For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        /// </summary>
        /// <param name="bundles"></param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Content/iransans.css", "~/Content/bootstrap.css", "~/Content/font-awesome.css",
                    "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/script")
                .Include("~/Scripts/jquery-3.1.0.min.js", "~/Scripts/bootstrap.min.js", "~/Scripts/jquery.noty.packaged.min.js",
                    "~/Scripts/Custome/noty.alerts.js"));

            BundleTable.EnableOptimizations = true;
        }
    }

    /// <summary>
    /// </summary>
    internal class NonOrderingBundleOrderer : IBundleOrderer
    {
        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <param name="files"></param>
        /// <returns></returns>
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files;
        }
    }
}