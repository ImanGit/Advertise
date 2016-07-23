using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Advertise.Web.Controllers
{
    public partial class UserController : Controller
    {
        // GET: User
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}