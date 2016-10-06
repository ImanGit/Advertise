using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Companies.CompanyImage1;
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

        #region Read

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<CompanyImageCreateViewModel> GetForCreateAsync();

        IList<CompanyImageListViewModel> GetChildList(Guid? parentId);

        IList<CompanyImageListViewModel> GetParentList();

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CompanyImageEditViewModel> GetForEditAsync(Guid id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<CompanyImageDeleteViewModel> GetForDeleteAsync(Guid id);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CompanyImageListViewModel>> GetListAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CompanyImageDetailsViewModel> GetDetailsAsync(Guid id);

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CompanyImageListViewModel> FindById(Guid id);

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        Task FillCreateViewModel(CompanyImageCreateViewModel viewModel);

        #endregion
    }
}