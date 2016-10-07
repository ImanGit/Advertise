using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Products.ProductCommentReport ;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Advertise.ServiceLayer.Contracts.Products
{
    public  interface IProductCommentReportService
    {

        #region Create
        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(ProductCrCreateViewModel  viewModel);
        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        Task EditAsync(ProductCrEditViewModel viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(ProductCrDeleteViewModel viewModel);
        #endregion
       
        #region Read

        Task<ProductCrCreateViewModel> GetForCreateAsync();

        Task<ProductCrEditViewModel > GetForEditAsync(Guid id);

        Task<ProductCrDeleteViewModel > GetForDeleteAsync(Guid id);

        Task<IEnumerable<ProductCrListViewModel>> GetListAsync();

        Task<ProductCrDetailViewModel > GetDetailsAsync(Guid id);

        Task<ProductCrListViewModel > FindById(Guid id);

        Task FillCreateViewModel(ProductCrCreateViewModel viewModel);

        #endregion

        #region
        void GetReportId();

        /// <summary>
        /// همه گزارشهای مربوط به یک محصول
        /// </summary>
        void GetAllReportProduct();

        /// <summary>
        /// تعداد گزارشهای مربوط به یک محصول
        /// </summary>
        void GetCountAllReportProduct();

        /// <summary>
        /// همه گزارشهای مربوط به همه محصول
        /// </summary>
        void GetAllReportProducts();

        /// <summary>
        /// تعداد گزارشهای مربوط به همه محصول
        /// </summary>
        void GetCountAllReportProducts();




        #endregion

        #region Find

        /// <summary>
        /// جستجوی کمپانی مورد نظر
        /// </summary>
        void FindCompany();

        #endregion
    }
}
