using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Companies.CompanyReport;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    interface ICompanyReportService : IBaseService

    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(CompanyRCreateViewModel viewModel);
        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        Task EditAsync(CompanyREditViewModel viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(CompanyRDeleteViewModel viewModel);
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

      
    }
}
