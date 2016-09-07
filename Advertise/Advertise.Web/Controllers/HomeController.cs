using System.Web.Mvc;
using Advertise.Common.Controller;
using Advertise.DataLayer.Context;

namespace Advertise.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HomeController : BaseController
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