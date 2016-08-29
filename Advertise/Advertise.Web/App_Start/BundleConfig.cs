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