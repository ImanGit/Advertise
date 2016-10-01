using System;
using System.Web.Mvc;
using Advertise.Common.Controller;
using Advertise.DataLayer.Context;
using Advertise.ServiceLayer.Contracts.Categories ;

namespace Advertise.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HomeController : BaseController
    {
        public HomeController(IUnitOfWork unitOfWork, ICategoryFollowService  categoriFollowService)
        {
            _unitOfWork = unitOfWork;
            _categoriFollowService = categoriFollowService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual ActionResult Index()
        {

            TempData["kk"]=
            _categoriFollowService.GetUserFollowCategory(  new Guid("9d2b0228-4d0d-4c23-8b49-01a698857709"), new Guid("14384759-99f1-ae8d-b041-17825978e396"));



          //  throw new Exception();

            return View();

            

        }


        #region Fields

        private readonly ICategoryFollowService _categoriFollowService;
        private readonly IUnitOfWork _unitOfWork;

        #endregion
    }
}