using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Companies;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanyImageService :IBaseService 
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(CompanyImageCreateViewModel viewModel);

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

        Task EditAsync(CompanyImageEditViewModel viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(CompanyImageDeleteViewModel  viewModel);
        #endregion

        #region Read

        Task<CompanyImageCreateViewModel> GetForCreateAsync();

        Task<CompanyImageEditViewModel> GetForEditAsync(Guid id);

        Task<CompanyImageDeleteViewModel> GetForDeleteAsync(Guid id);

        Task<IEnumerable<CompanyImageListViewModel>> GetListAsync();

        Task<CompanyImageDetailsViewModel> GetDetailsAsync(Guid id);

        Task<CompanyImageListViewModel> FindById(Guid id);

        Task FillCreateViewModel(CompanyImageCreateViewModel viewModel);

        #endregion


        #region Retrieve
        /// <summary>
        /// تعداد کل عکسها
        /// </summary>
        int GetCountAllImage();

        /// <summary>
        /// نمایش همه عکسها
        /// </summary>
        /// <returns></returns>
        int GetAllImage();

        /// <summary>
        /// تعداد کل عکسهای یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetCountAllImageCompany();

        /// <summary>
        /// نمایش کل عکسهای یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetAllImageCompany();

        /// <summary>
        /// تعداد عکسهای قابل ثبت برای یک کمپانی با توجه به پلن خریداری شده
        /// </summary>
        /// <returns></returns>
        int GetCountImageInPlan();

        #endregion

    }
}