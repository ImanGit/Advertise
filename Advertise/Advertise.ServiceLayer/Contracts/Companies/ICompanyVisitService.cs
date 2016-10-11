using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Companies.CompanyVisit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanyVisitService : IBaseService
    {
        #region Create

        Task CreateAsync(CompanyVisitCreateViewModel viewModel);
        Task<CompanyVisitCreateViewModel> GetForCreateAsync();
        #endregion

        #region Retrieve

        /// <summary>
        /// بازدید کل کمپانی
        /// </summary>
        int GetCountAllVisitComany();

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
