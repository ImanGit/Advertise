using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Advertise.Common.Controller;
using Advertise.Common.Extensions;
using Advertise.DataLayer.Context;
using Advertise.ServiceLayer.Contracts.Categories;
using Advertise.ViewModel.Models.Categories;

namespace Advertise.Web.Controllers
{
    /// <summary>
    /// </summary>
    public partial class CategoryController : BaseController
    {
        #region Ctor

        /// <summary>
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="categoryService"></param>
        public CategoryController(IUnitOfWork unitOfWork, ICategoryService categoryService)
        {
            _unitOfWork = unitOfWork;
            _categoryService = categoryService;
        }

        #endregion

        /// <summary>
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public virtual ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public virtual async Task<ActionResult> Create()
        {
            var viewModel = await _categoryService.GetForCreateAsync();
            return View(viewModel);
        }

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateInput(false)]
        public virtual async Task<ActionResult> Create(CategoryCreateViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _categoryService.CreateAsync(viewModel);
            this.ShowInformationMessage("دسته جدید با موفقیت ثبت شد.");
            return RedirectToAction(MVC.Category.List());
        }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public virtual async Task<ActionResult> Edit(Guid id)
        {
            var viewModel = await _categoryService.GetForEditAsync(id);
            return View(viewModel);
        }

        [HttpPost]
        public virtual async Task<ActionResult> Edit(CategoryEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _categoryService.EditAsync(viewModel);
            this.ShowInformationMessage("دسته جدید با موفقیت ویرایش شد.");
            return RedirectToAction(MVC.Category.List());
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public virtual async Task<ActionResult> List()
        {
            var viewModel = await _categoryService.GetListAsync();
            return View(viewModel);
        }

        [HttpGet]
        public virtual async Task<ActionResult> Delete(Guid id)
        {
            var viewModel = await _categoryService.GetForDeleteAsync(id);
            return View(viewModel);
        }

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public virtual async Task<ActionResult> Delete(CategoryDeleteViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _categoryService.DeleteAsync(viewModel);
            this.ShowInformationMessage("دسته جدید با موفقیت حذف شد.");
            return RedirectToAction(MVC.Category.List());
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public virtual async Task<ActionResult> Details(Guid id)
        {
            var viewModel = await _categoryService.GetDetailsAsync(id);
            return View(viewModel);
        }

        public virtual ActionResult Find()
        {
            return View();
        }

        #region AjaxCall

        [HttpGet]
        public virtual JsonResult GetCategoryList(Guid? id)
        {
            if (id == null)
            {
                //دریافت ریشه‌ها
                return Json(
                    _categoryService.GetParentList(),
                    JsonRequestBehavior.AllowGet);
            }
            //دریافت فرزندهای یک ریشه
            return Json(
                _categoryService.GetChildList(id),
                JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region Fields

        private readonly ICategoryService _categoryService;
        private readonly IUnitOfWork _unitOfWork;

        #endregion
    }
}