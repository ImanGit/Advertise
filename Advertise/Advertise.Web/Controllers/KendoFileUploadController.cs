using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Advertise.Web.Controllers
{
    public partial class KendoFileUploadController : Controller
    {

        [HttpPost]
        public virtual ActionResult Save(IEnumerable<HttpPostedFileBase> ImageFileName)
        {
            // The Name of the Upload component is "files"
            if (ImageFileName != null)
            {
                foreach (var file in ImageFileName)
                {
                    // Some browsers send file names with full path.
                    // We are only interested in the file name.
                    var fileName = System.IO.Path.GetFileName(file.FileName);
                    var physicalPath = System.IO.Path.Combine(Server.MapPath("~/Uploads"), fileName);

                    // The files are not actually saved in this demo
                    file.SaveAs(physicalPath);

                }
            }

            // Return an empty string to signify success
            return Content("");
        }

        [HttpPost]
        public virtual ContentResult Remove(string[] fileNames)
        {
            // The parameter of the Remove action must be called "fileNames"

            if (fileNames != null)
            {
                foreach (var fullName in fileNames)
                {
                    var fileName = System.IO.Path.GetFileName(fullName);
                    var physicalPath = System.IO.Path.Combine(Server.MapPath("~/Uploads"), fileName);

                    // TODO: Verify user permissions

                    if (System.IO.File.Exists(physicalPath))
                    {
                        // The files are not actually removed in this demo
                        System.IO.File.Delete(physicalPath);

                    }
                }
            }

            // Return an empty string to signify success
            return Content("");
        }



    }
}