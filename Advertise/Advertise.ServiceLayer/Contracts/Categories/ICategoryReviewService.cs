using System.Threading.Tasks;
using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Categories.CategoryReview;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Advertise.ServiceLayer.Contracts.Categories

{
    public interface ICategoryReviewService : IBaseService
    {
        #region Create

        /// <summary>
        ///     ایجاد نقد و بررسی
        /// </summary>
        /// <param name="viewModel"></param>
        Task  CreateAsync(CategoryReviewCreateViewModel viewModel );

        #endregion

        #region Update

        /// <summary>
        ///     اصلاح نقد و بررسی
        /// </summary>
        Task  EditAsync(CategoryReviewEditViewModel viewModel);

        /// <summary>
        ///     نمایش یا عدم نمایش نقد و بررسی
        /// </summary>
        /// <returns></returns>
        bool EditForIsShowOrNotShow();

        #endregion

        #region Retrieve

        
        /// <summary>
        ///     تعداد کل نقد و بررسی ها
        /// </summary>
        /// <returns></returns>
        bool GetCount();

        #endregion

        #region Read
        Task<CategoryReviewCreateViewModel> GetForCreateAsync();

        Task<CategoryReviewEditViewModel> GetForEditAsync(Guid id);

        Task<IEnumerable <CategoryReviewListViewModel>> GetListAsync();

        Task<CategoryReviewDetailsViewModel> GetDetailsAsync(Guid id);
        #endregion
    }
}