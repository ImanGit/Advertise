using Advertise.ServiceLayer.Contracts.Common;
namespace Advertise.ServiceLayer.Contracts.Products
{
    public interface IProductImageService:IBaseService 
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        void Create();

        #endregion

        #region Update

        /// <summary>
        /// اصلاح الویت عکسهای یک محصول یک شرکت
        /// </summary>
        /// <returns></returns>
        int EditOrderImageProductForComany();


        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        void Delete();

        #endregion

          #region Retrieve
        /// <summary>
        /// تعداد کل عکسها
        /// </summary>
        int GetCountAllImage();

        /// <summary>
        /// نمایش همه عکسها
        /// </summary>
        /// <returns></returns>
        int GetAllImage();

        /// <summary>
        /// تعداد عکسهای یک محصول از یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetCountImageProductCompany();

        /// <summary>
        /// نمایش عکسهای یک محصول از یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetImageProductCompany();

        /// <summary>
        /// تعداد کل عکسهای یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetCountAllImageCompany();

        /// <summary>
        /// تعداد عکسهای قابل ثبت برای یک محصول یک کمپانی با توجه به پلن خریداری شده
        /// </summary>
        /// <returns></returns>
        int GetCountImageInPlan();






        #endregion
    }
}