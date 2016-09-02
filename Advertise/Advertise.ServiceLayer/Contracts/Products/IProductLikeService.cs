using Advertise.ServiceLayer.Contracts.Common;

namespace Advertise.ServiceLayer.Contracts.Products
{
    /// <summary>
    /// </summary>
    public interface IProductLikeService : IBaseService
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