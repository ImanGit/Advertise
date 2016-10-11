using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Companies.CompanyAttachment;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanyAttachmentService : IBaseService
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(CompanyAttachmentCreateViewModel viewModel);

        #endregion

        #region Update
        /// <summary>
        /// ویرایش عکس یک محصول یک شرکت
        /// </summary>
        void EditImageProductForComany();

        /// <summary>
        /// اصلاح عکسهای یک شرکت
        /// </summary>
        /// <returns></returns>
        int EditImageForComany();

        Task EditAsync(CompanyAttachmentEditViewModel viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(CompanyAttachmentDeleteViewModel viewModel);
        #endregion

        #region Read

        Task<CompanyAttachmentCreateViewModel> GetForCreateAsync();

        Task<CompanyAttachmentEditViewModel> GetForEditAsync(Guid id);

        Task<CompanyAttachmentDeleteViewModel> GetForDeleteAsync(Guid id);

        Task<IEnumerable<CompanyAttachmentListViewModel>> GetListAsync();

        Task<CompanyAttachmentDetailsViewModel> GetDetailsAsync(Guid id);

        Task<CompanyAttachmentListViewModel> FindById(Guid id);

        Task FillCreateViewModel(CompanyAttachmentCreateViewModel viewModel);

        #endregion



        #region Retrieve

        /// <summary>
        /// </summary>
        void Get();

        /// <summary>
        /// تعداد اتچ های یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetCountCompanyAttach();

        /// <summary>
        /// نمایش اتچهای یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetOneCompanyAttach();

        /// <summary>
        /// نمایش تمام اتچ ها
        /// </summary>
        /// <returns></returns>
        int GetCompanyAttach();

        /// <summary>
        /// تعداد کل اتچها
        /// </summary>
        /// <returns></returns>
        int GetAllCount();

        /// <summary>
        /// گرفتن کد اتچ جهت نمایش
        /// </summary>
        /// <returns></returns>
        int GetAttachmentByCode();

        #endregion

        #region Find

        int Find();

        #endregion
    }
}