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
        public static void RegisterByndle(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/bootstrap").Include("~/Content/bootstrap.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
