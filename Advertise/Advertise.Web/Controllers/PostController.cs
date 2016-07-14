using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Advertise.Web.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index()
        {
            ViewBag.Iman = "iman hastam";
            ViewBag.AR = "ARRRR";
            return View();
        }
    }
}