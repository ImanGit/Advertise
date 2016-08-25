using Advertise.ServiceLayer.Contracts.Common;

namespace Advertise.ServiceLayer.Contracts.Categories
{
    public interface ICategoryService : IBaseService
    {
        #region Create

        /// <summary>
        /// </summary>
        void Add();

        #endregion

        #region Update

        /// <summary>
        /// </summary>
        void Edit();

        #endregion

        #region Retrieve

        /// <summary>
        ///     گرفتن تعداد کل دسته بندی ها
        /// </summary>
        int GetAllCount();

        /// <summary>
        ///     گرفتن آخرین دسته بندی ها بر اساس روز
        /// </summary>
        /// <returns></returns>
        int GetLastToDay();

        /// <summary>
        /// </summary>
        void FindById();

        #endregion

        #region Delete

        /// <summary>
        ///     پاک کردن به صورت منطقی
        /// </summary>
        bool Remove();

        /// <summary>
        ///     پاک کردن به صورت فیزیکی
        /// </summary>
        /// <returns></returns>
        bool RemoveHard();

        #endregion
    }
}