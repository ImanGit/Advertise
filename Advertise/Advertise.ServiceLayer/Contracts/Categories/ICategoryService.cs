using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Categories.Category;

namespace Advertise.ServiceLayer.Contracts.Categories
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICategoryService : IBaseService
    {
        #region Create

        /// <summary>
        /// </summary>
        Task CreateAsync(CategoryCreateViewModel viewModel);

        #endregion

        #region Read

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CategoryListViewModel>> GetListAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CategoryEditViewModel> GetForEditAsync(Guid id);

        /// <summary>
        /// </summary>
        Task<CategoryListViewModel> FindById(Guid id);

        #endregion

        #region Update

        /// <summary>
        /// </summary>
        Task EditAsync(CategoryEditViewModel viewModel);

        #endregion

        #region Delete

        /// <summary>
        ///     پاک کردن به صورت منطقی
        /// </summary>
        Task DeleteAsync(Guid id);

        #endregion
    }
}