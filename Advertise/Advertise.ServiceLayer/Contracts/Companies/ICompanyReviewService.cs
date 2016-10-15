using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Companies.CompanyReview ;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanyReviewService : IBaseService
    {

        #region Create
        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(CompanyReviewCreateViewModel  viewModel);
        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        Task EditAsync(CompanyReviewEditViewModel viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(CompanyReviewDeleteViewModel viewModel);
        #endregion

        #region Read

        Task<CompanyReviewCreateViewModel> GetForCreateAsync();

        Task<CompanyReviewEditViewModel> GetForEditAsync(Guid id);

        Task<CompanyReviewDeleteViewModel> GetForDeleteAsync(Guid id);

        Task<IEnumerable<CompanyReviewListViewModel>> GetListAsync();

        Task<CompanyReviewDetailViewModel> GetDetailsAsync(Guid id);

        Task<CompanyReviewListViewModel> FindById(Guid id);

        Task FillCreateViewModel(CompanyReviewCreateViewModel viewModel);

        #endregion

        #region Retrieve

        /// <summary>
        /// تعداد کل نقد و بررسی های شرکتها
        /// </summary>
        void GetCountAllReviwe();

        /// <summary>
        /// گرفتن آی دی شرکت برای نمایش نقد و بررسی
        /// </summary>
        void GetIdCompanyForShowReview();

        #endregion

       
    }
}