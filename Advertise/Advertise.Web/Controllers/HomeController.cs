using System.Web.Mvc;
using Advertise.DataLayer.Context;

namespace Advertise.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}