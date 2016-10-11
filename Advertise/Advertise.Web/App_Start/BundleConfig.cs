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
                .Include("~/Content/Customs/iransans.css",
                    "~/Content/Bootstrap/bootstrap.css",
                    "~/Content/FontAwesome/font-awesome.css",
                    "~/Content/Customs/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/script")
                .Include("~/Scripts/JQuery/jquery-3.1.0.js",
                    "~/Scripts/Bootstrap/bootstrap.js",
                    "~/Scripts/Noty/jquery.noty.packaged.js",
                    "~/Scripts/Customs/noty.alerts.js",
                    "~/Scripts/Customs/site.js"));

            bundles.Add(new StyleBundle("~/Content/kendoui/css")
                .Include("~/Content/KendoUI/kendo.common.min.css",
                "~/Content/KendoUI/kendo.rtl.min.css",
                "~/Content/KendoUI/kendo.bootstrap.min.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/kendo/js")
                .Include("~/Scripts/KendoUI/js/jquery.min.js",
                "~/Scripts/KendoUI/js/jszip.min.js",
                "~/Scripts/KendoUI/js/kendo.web.min.js",
                "~/Scripts/KendoUI/js/cultures/kendo.culture.fa-IR.min.js",
                "~/Scripts/KendoUI/js/cultures/kendo.culture.fa.min.js",
                "~/Scripts/KendoUI/js/messages/kendo.messages.fa-IR.min.js",
                "~/Scripts/Customs/kendo.datasource.js",
                "~/Scripts/Customs/kendo.ui.js"));

            

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