using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Advertise.Common.Controller;
using Advertise.Common.Extensions;
using Advertise.DataLayer.Context;
using Advertise.ServiceLayer.Contracts.Companies;
using Advertise.ViewModel.Models.Companies;

namespace Advertise.Web.Controllers
{
    public partial  class CompanyController : BaseController
    {
        #region Ctor

        public CompanyController(IUnitOfWork unitOfWork, ICompanyService companyService)
        {
            _unitOfWork = unitOfWork;
            _comanyService  = companyService;
        }

        #endregion

        [HttpGet]
        public virtual ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public virtual async Task<ActionResult> Create()
        {
            var viewModel = await _comanyService.GetForCreateAsync();
            return PartialView( viewModel);
        }

        [HttpPost]
        public virtual async Task<ActionResult> Create(CompanyCreateViewModel viewModel)
        {
            if (!ModelState .IsValid )
            {
                return PartialView( );
            }
            await _comanyService  .CreateAsync(viewModel);
            this.ShowInformationMessage("شرکت جدید با موفقیت ثبت شد");
            return RedirectToAction(MVC.Company .List());
        }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public virtual async Task<ActionResult> Edit(Guid id)
        {
            var viewModel = await _comanyService.GetForEditAsync(id);
            return PartialView(viewModel);
        }

        [HttpPost]
        public virtual async Task<ActionResult> Edit(CompanyEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return PartialView( );
            }
            await _comanyService.EditAsync(viewModel);
            this.ShowInformationMessage("شرکت  با موفقیت ویرایش شد.");
            return RedirectToAction(MVC.Company.List());
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public virtual async Task<ActionResult> List()
        {
            var viewModel = await _comanyService.GetListAsync();
            return View(viewModel);
        }

        [HttpGet]
        public virtual async Task<ActionResult> Delete(Guid id)
        {
            var viewModel = await _comanyService.GetForDeleteAsync(id);
            return View(viewModel);
        }

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public virtual async Task<ActionResult> Delete(CompanyDeleteViewModel  viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _comanyService .DeleteAsync( viewModel);
            this.ShowInformationMessage("دسته جدید با موفقیت حذف شد.");
            return RedirectToAction(MVC.Company .List());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public virtual async Task<ActionResult> Details(Guid id)
        {
            var viewModel = await _comanyService.GetDetailsAsync(id);
            return View(viewModel);
        }

        public virtual ActionResult Find()
        {
            return View();
        }


        #region Fields

        private readonly ICompanyService _comanyService;
        private readonly IUnitOfWork _unitOfWork;

        #endregion
    }
}