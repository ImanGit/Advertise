using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Products.ProductCommentLike ;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Products
{
    public interface IProductCommentLikeService : IBaseService
    {
        #region Create
        /// <summary>
        /// ایجاد فالو یک کمپانی
        /// </summary>
        Task CreateAsync(ProductClCreateViewModel viewModel);

        #endregion

        #region Update
        /// <summary>
        /// فالو کردن مجدد یک کمپانی یا آن فالو کردن
        /// </summary>
        void EditForFollowOrUnFollow();

        Task EditAsync(ProductClEditViewModel  viewModel);

        /// <summary>
        /// لایک مجدد یا پس گرفتن لایک سوال
        /// </summary>
        void EditForLikeOrUnlike();

        #endregion

        #region Read
        Task<ProductClCreateViewModel> GetForCreateAsync();

        Task<ProductClEditViewModel> GetForEditAsync(Guid id);

        #endregion

        #region Retrieve

        /// <summary>
        /// تعداد لایکهای کامنت یک محصول
        /// </summary>
        /// <returns></returns>
        int GetCommentLikedCount();

        /// <summary>
        /// تعداد لایک های پس گرفته شده
        /// </summary>
        /// <returns></returns>
        int GetCommentDisLikedCount();

        /// <summary>
        /// تعداد لایکهای یک شخص برای کامنت های مختلف
        /// </summary>
        /// <returns></returns>
        int GetUserLikedCount();

        /// <summary>
        /// تعداد لایکهای یک شخص که پس گرفته شده است
        /// </summary>
        /// <returns></returns>
        int GetUserDisLikedCount();

        /// <summary>
        /// گرفتن لایک یک شخص برای یک کامنت (برای زمانی که شخص وارد صفحه کامنت  مشود لایک یا عدم لایک آن مشخص شود)
        /// </summary>
        /// <returns></returns>
        bool GetUserLikeForOneComment();

        /// <summary>
        /// نمایش همه کاربرانی که کامنت را لایک کرده اند
        /// </summary>
        void GetAlluserLikeForOneProduct();

        #endregion

    }
}