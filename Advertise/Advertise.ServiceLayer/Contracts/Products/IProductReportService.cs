using Advertise.ViewModel.Models.Products.ProductReport ;
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
        Task CreateAsync(ProductRCreateViewModel viewModel);
        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        Task EditAsync(ProductREditViewModel viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(ProductRDeleteViewModel viewModel);
        #endregion

        #region Read

        Task<ProductRCreateViewModel> GetForCreateAsync();

        Task<ProductREditViewModel> GetForEditAsync(Guid id);

        Task<ProductRDeleteViewModel> GetForDeleteAsync(Guid id);

        Task<IEnumerable<ProductRListViewModel>> GetListAsync();

        Task<ProductRDetailViewModel> GetDetailsAsync(Guid id);

        Task<ProductRListViewModel> FindById(Guid id);

        Task FillCreateViewModel(ProductRCreateViewModel viewModel);

        #endregion


    }
}
