using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Companies.CompanyQuestionLike ;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanyQuestionLikeService :IBaseService 
    {
        #region Create
        /// <summary>
        /// ایجاد فالو یک کمپانی
        /// </summary>
        Task CreateAsync(CompanyQlCreateViewModel viewModel);

        #endregion

        #region Update
        /// <summary>
        /// فالو کردن مجدد یک کمپانی یا آن فالو کردن
        /// </summary>
        void EditForFollowOrUnFollow();

        Task EditAsync(CompanyQlEditViewModel viewModel);
        #endregion


        #region Update
        /// <summary>
        /// لایک مجدد یا پس گرفتن لایک سوال
        /// </summary>
        void EditForLikeOrUnlike();

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        void Delete();

        #endregion

        #region Retrieve
        /// <summary>
        /// تعداد لایکهای یک سوال
        /// </summary>
        void GetCountForques();

        /// <summary>
        /// نمایش تمامی کاربرانی که سوال را لایک کرده اند
        /// </summary>
        /// <returns></returns>
        int GetAlluserLikeQestion();

        /// <summary>
        /// آیا شخص سوال را لایک کرده؟
        /// </summary>
        /// <returns></returns>
        bool GetLikeForUser();

        /// <summary>
        /// تعداد کل لایکهایی که یک شخص انجام داده
        /// </summary>
        /// <returns></returns>
        int GetCountAllLikeUser();

        /// <summary>
        /// نمایش کل لایکهایی که یک شخص انجام داده
        /// </summary>
        /// <returns></returns>
        int GetAllLikeUser();

        #endregion

        #region Read
        Task<CompanyQlCreateViewModel> GetForCreateAsync();

        Task<CompanyQlEditViewModel> GetForEditAsync(Guid id);

        #endregion
    }
}