using System;
using Advertise.ServiceLayer.Contracts.Common;

namespace Advertise.ServiceLayer.Contracts.Categories
{
    public interface ICategoryServicer :IBaseService 
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        void Create();

        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        void EditCategory( );

        #endregion

        #region Delete
        /// <summary>
        /// پاک کردن به صورت منطقی
        /// </summary>
        bool DeleteCategory();

        /// <summary>
        /// پاک کردن به صورت فیزیکی
        /// </summary>
        /// <returns></returns>
        bool DeleteHard();

        #endregion

        #region Retrieve
        /// <summary>
        /// گرفتن تعداد کل دسته بندی ها
        /// </summary>
        int GetAllCountCategory();

        /// <summary>
        /// گرفتن آخرین دسته بندی ها بر اساس روز
        /// </summary>
        /// <returns></returns>
        int GetLastToDay();



        #endregion
    }
}