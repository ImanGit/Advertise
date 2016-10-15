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
        Task CreateAsync(ProductCommentReportCreateViewModel  viewModel);
        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        Task EditAsync(ProductCommentReportEditViewModel viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(ProductCommentReportDeleteViewModel viewModel);
        #endregion
       
        #region Read

        Task<ProductCommentReportCreateViewModel> GetForCreateAsync();

        Task<ProductCommentReportEditViewModel > GetForEditAsync(Guid id);

        Task<ProductCommentReportDeleteViewModel > GetForDeleteAsync(Guid id);

        Task<IEnumerable<ProductCommentReportListViewModel>> GetListAsync();

        Task<ProductCommentReportDetailViewModel > GetDetailsAsync(Guid id);

        Task<ProductCommentReportListViewModel > FindById(Guid id);

        Task FillCreateViewModel(ProductCommentReportCreateViewModel viewModel);

        #endregion

        #region Retrive
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
