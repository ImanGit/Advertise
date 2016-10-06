using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Advertise.Web.Controllers
{
    public partial class KendoEditorFilesController : Controller
    {
        //مسیر پوشه فایل‌ها
        protected string FilesFolder = "~/Uploads";

        protected string KendoFileType = "f";
        protected string KendoDirType = "d";

        [HttpPost]
        public virtual ActionResult CreateFolder(string name, string path)
        {
            //تمیز سازی امنیتی
            name = Path.GetFileName(name);
            path = GetSafeDirPath(path);
            var dirToCreate = Path.Combine(path, name);

            Directory.CreateDirectory(dirToCreate);

            return KendoFile(new KendoFile
            {
                Name = name,
                Type = KendoDirType
            });
        }

        [HttpPost]
        public virtual ActionResult DestroyFile(string name, string path)
        {
            //تمیز سازی امنیتی
            name = Path.GetFileName(name);
            path = GetSafeDirPath(path);

            var pathToDelete = Path.Combine(path, name);

            var attr = System.IO.File.GetAttributes(pathToDelete);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                Directory.Delete(pathToDelete, recursive: true);
            }
            else
            {
                System.IO.File.Delete(pathToDelete);
            }

            return Json(new object[0]);
        }

        [HttpGet]
        public virtual ActionResult GetFile(string path)
        {
            path = GetSafeFileAndDirPath(path);
            return File(path, "image/png");
        }

        [HttpGet]
        public virtual ActionResult GetFilesList(string path)
        {
            path = GetSafeDirPath(path);
            var imagesList = new DirectoryInfo(path)
                                .GetFiles()
                                .Select(fileInfo => new KendoFile
                                {
                                    Name = fileInfo.Name,
                                    Size = fileInfo.Length,
                                    Type = KendoFileType
                                }).ToList();

            var foldersList = new DirectoryInfo(path)
                                .GetDirectories()
                                .Select(directoryInfo => new KendoFile
                                {
                                    Name = directoryInfo.Name,
                                    Type = KendoDirType
                                }).ToList();

            return new ContentResult
            {
                Content = JsonConvert.SerializeObject(imagesList.Union(foldersList), new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                }),
                ContentType = "application/json",
                ContentEncoding = Encoding.UTF8
            };
        }

        [HttpPost]
        public virtual ActionResult UploadFile(HttpPostedFileBase file, string path)
        {
            //تمیز سازی امنیتی
            var name = Path.GetFileName(file.FileName);
            path = GetSafeDirPath(path);
            var pathToSave = Path.Combine(path, name);

            file.SaveAs(pathToSave);

            return KendoFile(new KendoFile
            {
                Name = name,
                Size = file.ContentLength,
                Type = KendoFileType
            });
        }

        protected string GetSafeDirPath(string path)
        {
            // path = مسیر زیر پوشه‌ی وارد شده
            if (string.IsNullOrWhiteSpace(path))
            {
                return Server.MapPath(FilesFolder);
            }

            //تمیز سازی امنیتی
            path = Path.GetDirectoryName(path);
            path = Path.Combine(Server.MapPath(FilesFolder), path);
            return path;
        }

        protected string GetSafeFileAndDirPath(string path)
        {
            // path = مسیر فایل و زیر پوشه‌ی وارد شده

            //تمیز سازی امنیتی
            var name = Path.GetFileName(path);
            var dir = string.Empty;
            if (!string.IsNullOrWhiteSpace(path))
            {
                dir = Path.GetDirectoryName(path);
            }

            path = Path.Combine(Server.MapPath(FilesFolder), dir, name);
            return path;
        }

        protected ActionResult KendoFile(KendoFile file)
        {
            return new ContentResult
            {
                Content = JsonConvert.SerializeObject(file,
                    new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    }),
                ContentType = "application/json",
                ContentEncoding = Encoding.UTF8
            };
        }
    }




    public class KendoFile
    {
        public string Name { set; get; }
        public string Type { set; get; }
        public long Size { set; get; }
    }
}