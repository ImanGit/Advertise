using System.Web.Mvc;

namespace Advertise.Web.Controllers
{
    public partial class KendoEditorImagesController : KendoEditorFilesController
    {
        public KendoEditorImagesController()
        {
            // بازنویسی مسیر پوشه‌ی فایل‌ها
            FilesFolder = "~/Uploads";
        }

        [HttpGet]
        [OutputCache(Duration = 3600, VaryByParam = "path")]
        public virtual ActionResult GetThumbnail(string path)
        {
            //todo: create thumb/ resize image

            path = GetSafeFileAndDirPath(path);
            return File(path, "image/png");
        }
    }
}