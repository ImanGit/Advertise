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

        // GET: Category
        [HttpGet]
        public virtual async Task<ActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public virtual async Task<ActionResult> Create(AddCategoryViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _categoryService.Add(viewModel);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
            this.NotyError("دسته جدید با موفقیت ثبت شد.");
            return RedirectToAction(MVC.Category.Create());
        }
    }
}