using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Companies.CompanyQuestionReport  ;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    interface ICompanyQuestionReportService :IBaseService 

    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(CompanyQrCreateViewModel viewModel);
        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        Task EditAsync(CompanyQrEditViewModel viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(CompanyQrDeleteViewModel viewModel);
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

        #region Read

        Task<CompanyQrCreateViewModel> GetForCreateAsync();

        Task<CompanyQrEditViewModel> GetForEditAsync(Guid id);

        Task<CompanyQrDeleteViewModel> GetForDeleteAsync(Guid id);

        Task<IEnumerable<CompanyQrListViewModel>> GetListAsync();

        Task<CompanyQrDetailViewModel> GetDetailsAsync(Guid id);

        Task<CompanyQrListViewModel> FindById(Guid id);

        Task FillCreateViewModel(CompanyQrCreateViewModel viewModel);

        #endregion
    }
}
