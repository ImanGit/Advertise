using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Companies.CompanyFollow ;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanyFollowService :IBaseService 
    {
        #region Create
        /// <summary>
        /// ایجاد فالو یک کمپانی
        /// </summary>
        Task CreateAsync(CompanyFollowCreateViewModel viewModel);

        #endregion

        #region Update
        /// <summary>
        /// فالو کردن مجدد یک کمپانی یا آن فالو کردن
        /// </summary>
        void EditForFollowOrUnFollow();

        Task EditAsync(CompanyFollowEditViewModel viewModel);
        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        void Delete();

        #endregion

        #region Retrieve
        /// <summary>
        /// تعداد همه فالورها
        /// </summary>
        int GetCountAll();

        /// <summary>
        /// نمایش همه فالورها
        /// </summary>
        /// <returns></returns>
        int GetAll();

        /// <summary>
        /// تعداد فالورهای یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetConutFollowerForOneCompany();

        /// <summary>
        /// نمایش فالورهای یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetFollowerForOneCompany();

        /// <summary>
        /// کاربری که یک کمپانی را فالو کرده
        /// </summary>
        /// <returns></returns>
        int GetUserforFollowCompany();

        /// <summary>
        /// تعداد فالورهایی که کاربر انجام داده
        /// </summary>
        /// <returns></returns>
        int GetCountAllFollowerUser();

        /// <summary>
        ///نمایش همه فالورهای یک شخص
        /// </summary>
        /// <returns></returns>
        int GetAllFollowerUser();

        #endregion

        #region Read
        Task<CompanyFollowCreateViewModel> GetForCreateAsync();

        Task<CompanyFollowEditViewModel> GetForEditAsync(Guid id);

        Task<IEnumerable<CompanyFollowListViewModel>> GetListAsync();
        #endregion
    }
}