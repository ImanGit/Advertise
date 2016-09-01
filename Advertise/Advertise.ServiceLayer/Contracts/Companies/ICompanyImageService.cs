using Advertise.ServiceLayer.Contracts.Common;
namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanyImageService :IBaseService 
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        void Create();

        #endregion

        #region Update
        /// <summary>
        /// ویرایش عکس یک محصول یک شرکت
        /// </summary>
        void EditImageProductForComany();

        /// <summary>
        /// اصلاح عکسهای یک شرکت
        /// </summary>
        /// <returns></returns>
        int EditImageForComany();

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
        /// تعداد کل عکسهای یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetCountAllImageCompany();

        /// <summary>
        /// نمایش کل عکسهای یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetAllImageCompany();

        /// <summary>
        /// تعداد عکسهای قابل ثبت برای یک کمپانی با توجه به پلن خریداری شده
        /// </summary>
        /// <returns></returns>
        int GetCountImageInPlan();

        #endregion
    }
}