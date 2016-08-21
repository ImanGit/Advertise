using Advertise.ServiceLayer.Contracts.Common;
namespace Advertise.ServiceLayer.Contracts.Categories

{
    public interface ICategoryReviewService : IBaseService
    {
        #region Create
        /// <summary>
        /// ایجاد نقد و بررسی
        /// </summary>
        /// <param name="viewModel"></param>
        bool Create( int Id);

        #endregion

        #region Update
        /// <summary>
        /// اصلاح نقد و بررسی
        /// </summary>
        bool Edit(int IdCat);

        /// <summary>
        /// نمایش یا عدم نمایش نقد و بررسی
        /// </summary>
        /// <returns></returns>
        bool EditForIsShowOrNotShow();

        


        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        void Delete();

        #endregion

        #region Retrieve
        /// <summary>
        /// 
        /// </summary>
        void Get();

        /// <summary>
        /// تعداد کل نقد و بررسی ها
        /// </summary>
        /// <returns></returns>
        bool GetCount();

        #endregion
    }
}