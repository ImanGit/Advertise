using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Products.ProductReview ;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Products
{
    public interface IProductReviewService : IBaseService
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(ProductRwCreateViewModel viewModel);
        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        Task EditAsync(ProductRwEditViewModel viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(ProductRwDeleteViewModel viewModel);
        #endregion

        #region Read

        Task<ProductRwCreateViewModel> GetForCreateAsync();

        Task<ProductRwEditViewModel> GetForEditAsync(Guid id);

        Task<ProductRwDeleteViewModel> GetForDeleteAsync(Guid id);

        Task<IEnumerable<ProductRwListViewModel>> GetListAsync();

        Task<ProductRwDetailViewModel> GetDetailsAsync(Guid id);

        Task<ProductRwListViewModel> FindById(Guid id);

        Task FillCreateViewModel(ProductRwCreateViewModel viewModel);

        #endregion

        #region Retrieve

        /// <summary>
        /// تعداد کل نقد و بررسی های محصولات
        /// </summary>
        void GetCountAllReviwe();

        /// <summary>
        /// گرفتن آی دی محصول برای نمایش نقد و بررسی
        /// </summary>
        void GetIdProductForShowReview();




        #endregion
    }
}