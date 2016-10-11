using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Advertise.Web.Controllers
{
    public partial class PostController : Controller
    {
        // GET: Post
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}