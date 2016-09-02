using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Advertise.Common.Extensions;
using Advertise.DataLayer.Context;
using Advertise.ServiceLayer.Contracts.Categories;
using Advertise.ViewModel.Models.Categories.Category;

namespace Advertise.Web.Controllers
{
    public partial class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork, ICategoryService categoryService)
        {
            _unitOfWork = unitOfWork;
            _categoryService = categoryService;
        }

        public virtual ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public virtual async Task<ActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public virtual async Task<ActionResult> Create(CategoryCreateViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _categoryService.CreateAsync(viewModel);
            this.NotyError("دسته جدید با موفقیت ثبت شد.");
            return RedirectToAction(MVC.Category.List());
        }

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
            this.NotyError("دسته جدید با موفقیت ویرایش شد.");
            return RedirectToAction(MVC.Category.List());
        }

        public virtual async Task<ActionResult> List()
        {
            var viewModel = await _categoryService.GetListAsync();
            return View(viewModel);
        }

        public virtual async Task<ActionResult> Delete(Guid id)
        {
            await _categoryService.DeleteAsync(id);
            this.NotyError("دسته جدید با موفقیت حذف شد.");
            return RedirectToAction(MVC.Category.List());
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Find()
        {
            return View();
        }
    }
}