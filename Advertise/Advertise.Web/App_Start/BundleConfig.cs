using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace Advertise.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Content/iransans.css","~/Content/bootstrap.css","~/Content/font-awesome.css","~/Content/Site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
