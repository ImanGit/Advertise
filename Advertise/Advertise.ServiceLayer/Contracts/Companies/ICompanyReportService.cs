using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.ServiceLayer.Contracts.Companies ;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    interface ICompanyReportService

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
        void Edit();

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        void Delete();

        #endregion

        #region Retrieve

        /// <summary>
        /// گرفتن آی دی ریپورت جهت نمایش آن
        /// </summary>
        void GetReportId();

        /// <summary>
        /// همه گزارشهای مربوط به یک کمپانی
        /// </summary>
        void GetAllReportCompany();

        /// <summary>
        /// تعداد گزارشهای مربوط به یک کمپانی
        /// </summary>
        void GetCountAllReportCompany();

        /// <summary>
        /// همه گزارشهای مربوط به همه کمپانی
        /// </summary>
        void GetAllReportCompanys();

        /// <summary>
        /// تعداد گزارشهای مربوط به همه کمپانی
        /// </summary>
        void GetCountAllReportCompanys();




        #endregion

        #region Find

        /// <summary>
        /// جستجوی کمپانی مورد نظر
        /// </summary>
        void FindCompany();

        #endregion
    }
}
