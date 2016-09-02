using Advertise.ServiceLayer.Contracts.Common;

namespace Advertise.ServiceLayer.Contracts.Products
{
    public interface IProductCommentLikeService : IBaseService
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