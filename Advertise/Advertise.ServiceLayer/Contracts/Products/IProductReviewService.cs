using Advertise.ServiceLayer.Contracts.Common;

namespace Advertise.ServiceLayer.Contracts.Products
{
    public interface IProductReviewService : IBaseService
    {
        #region Create

        /// <summary>
        /// </summary>
        void Create();

        #endregion

        #region Update

        /// <summary>
        /// </summary>
        void Edit();

        #endregion

        #region Delete

        /// <summary>
        /// </summary>
        void Delete();

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