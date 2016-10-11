using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Products.ProductImage;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Products
{
    public interface IProductImageService: IBaseService 
    {

       
        #region Create
        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(ProductImageCreateViewModel  viewModel);

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

        Task EditAsync(ProductImageEditViewModel viewModel);

        /// <summary>
        /// اصلاح الویت عکسهای یک محصول یک شرکت
        /// </summary>
        /// <returns></returns>
        int EditOrderImageProductForComany();


        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(ProductImageDeleteViewModel viewModel);
        #endregion

        #region Read

        Task<ProductImageCreateViewModel> GetForCreateAsync();

        Task<ProductImageEditViewModel> GetForEditAsync(Guid id);

        Task<ProductImageDeleteViewModel> GetForDeleteAsync(Guid id);

        Task<IEnumerable<ProductImageListViewModel>> GetListAsync();

        Task<ProductImageDetailViewModel> GetDetailsAsync(Guid id);

        Task<ProductImageListViewModel> FindById(Guid id);

        Task FillCreateViewModel(ProductImageCreateViewModel viewModel);

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
        /// تعداد عکسهای یک محصول از یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetCountImageProductCompany();

        /// <summary>
        /// نمایش عکسهای یک محصول از یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetImageProductCompany();

        /// <summary>
        /// تعداد کل عکسهای یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetCountAllImageCompany();

        /// <summary>
        /// تعداد عکسهای قابل ثبت برای یک محصول یک کمپانی با توجه به پلن خریداری شده
        /// </summary>
        /// <returns></returns>
        int GetCountImageInPlan();






        #endregion
    }
}