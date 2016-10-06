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

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<CompanyQrCreateViewModel> GetForCreateAsync();

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CompanyQrEditViewModel> GetForEditAsync(Guid id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<CompanyQrDeleteViewModel> GetForDeleteAsync(Guid id);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CompanyQrListViewModel>> GetListAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CompanyQrDetailViewModel> GetDetailsAsync(Guid id);

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CompanyQrListViewModel> FindById(Guid id);

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        Task FillCreateViewModel(CompanyQrCreateViewModel viewModel);

        #endregion
    }
}
