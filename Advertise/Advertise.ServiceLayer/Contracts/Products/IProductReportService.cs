using Advertise.ViewModel.Models.Products ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Products
{
    public  interface  IProductReportService
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(ProductReportCreateViewModel viewModel);
        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        Task EditAsync(ProductReportEditViewModel viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(ProductReportDeleteViewModel viewModel);
        #endregion

        #region Read

        Task<ProductReportCreateViewModel> GetForCreateAsync();

        Task<ProductReportEditViewModel> GetForEditAsync(Guid id);

        Task<ProductReportDeleteViewModel> GetForDeleteAsync(Guid id);

        Task<IEnumerable<ProductReportListViewModel>> GetListAsync();

        Task<ProductReportDetailViewModel> GetDetailsAsync(Guid id);

        Task<ProductReportListViewModel> FindById(Guid id);

        Task FillCreateViewModel(ProductReportCreateViewModel viewModel);

        #endregion

    }
}
