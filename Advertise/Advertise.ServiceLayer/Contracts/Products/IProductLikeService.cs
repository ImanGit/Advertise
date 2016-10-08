using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Products.ProductLike;
using System;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Products
{
    /// <summary>
    /// </summary>
    public interface IProductLikeService : IBaseService
    {
        #region Create
        /// <summary>
        /// ایجاد فالو یک کمپانی
        /// </summary>
        Task CreateAsync(ProductLikeCreateViewModel viewModel);

        #endregion

        #region Update
        /// <summary>
        /// فالو کردن مجدد یک کمپانی یا آن فالو کردن
        /// </summary>
        void EditForFollowOrUnFollow();

        Task EditAsync(ProductLikeEditViewModel viewModel);

        /// <summary>
        /// لایک مجدد یا پس گرفتن لایک سوال
        /// </summary>
        void EditForLikeOrUnlike();

        #endregion


        #region Read
        Task<ProductLikeCreateViewModel> GetForCreateAsync();

        Task<ProductLikeEditViewModel> GetForEditAsync(Guid id);

        #endregion

        #region Retrieve

        /// <summary>
        /// تعداد لایکهای یک محصول
        /// </summary>
        /// <returns></returns>
        int GetProductLikedCount();

        /// <summary>
        /// تعداد لایک های پس گرفته شده
        /// </summary>
        /// <returns></returns>
        int GetProductDisLikedCount();

        /// <summary>
        /// تعداد لایکهای یک شخص برای محصولات مختلف
        /// </summary>
        /// <returns></returns>
        int GetUserLikedCount();

        /// <summary>
        /// تعداد لایکهای یک شخص که پس گرفته شده است
        /// </summary>
        /// <returns></returns>
        int GetUserDisLikedCount();

        /// <summary>
        /// گرفتن لایک یک شخص برای یک محصول(برای زمانی که شخص وارد صفحه محصول مشود لایک یا عدم لایک آن مشخص شود)
        /// </summary>
        /// <returns></returns>
        bool GetUserLikeForOneProduct();

        #endregion
    }
}