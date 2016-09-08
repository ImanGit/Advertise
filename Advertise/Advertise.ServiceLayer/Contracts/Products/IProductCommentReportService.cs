using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Products
{
    public  interface IProductCommentReportService
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
        /// گرفتن آی دی ریپورت جهت نمایش آن
        /// </summary>
        void GetReportId();

        /// <summary>
        /// همه گزارشهای مربوط به یک محصول
        /// </summary>
        void GetAllReportProduct();

        /// <summary>
        /// تعداد گزارشهای مربوط به یک محصول
        /// </summary>
        void GetCountAllReportProduct();

        /// <summary>
        /// همه گزارشهای مربوط به همه محصول
        /// </summary>
        void GetAllReportProducts();

        /// <summary>
        /// تعداد گزارشهای مربوط به همه محصول
        /// </summary>
        void GetCountAllReportProducts();




        #endregion

        #region Find

        /// <summary>
        /// جستجوی کمپانی مورد نظر
        /// </summary>
        void FindCompany();

        #endregion
    }
}
