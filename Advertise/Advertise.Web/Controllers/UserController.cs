using System.Web.Mvc;
using Advertise.DataLayer.Context;

namespace Advertise.Web.Controllers
{
    public partial class UserController : Controller
    {
        // GET: User
        public virtual ActionResult Index()
        {
            return View();
        }


        //[AjaxOnly]
        public virtual ActionResult List()
        {
            using (var s = new ApplicationDbContext())
            {
                // var y =s.Users.Find(1);
            }
            return View();
        }

        public virtual ActionResult Myview()
        {
            return View();
        }
    }
}