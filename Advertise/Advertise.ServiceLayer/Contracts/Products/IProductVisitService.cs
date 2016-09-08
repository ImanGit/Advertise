using Advertise.ServiceLayer.Contracts.Common;

namespace Advertise.ServiceLayer.Contracts.Products
{
    public interface IProductVisitService : IBaseService
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
        /// بازدید کل محصول
        /// </summary>
        int GetCountAllVisit();

        /// <summary>
        /// تعداد بازدیدهای امروز
        /// </summary>
        /// <returns></returns>
        int GetCountForToday();

        /// <summary>
        /// تعداد بازدیدهای یک ماه گذشته
        /// </summary>
        /// <returns></returns>
        int GetCountForMonth();


        #endregion
    }
}