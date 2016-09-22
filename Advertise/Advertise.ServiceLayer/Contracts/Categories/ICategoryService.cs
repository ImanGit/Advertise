using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Categories;

namespace Advertise.ServiceLayer.Contracts.Categories
{
    /// <summary>
    /// </summary>
    public interface ICategoryService : IBaseService
    {
        #region Create

        /// <summary>
        /// </summary>
        Task CreateAsync(CategoryCreateViewModel viewModel);

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
        Task DeleteAsync(CategoryDeleteViewModel viewModel);

        #endregion

        #region Read

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<CategoryCreateViewModel> GetForCreateAsync();

        IList<CategoryListViewModel> GetChildList(Guid? parentId);

        IList<CategoryListViewModel> GetParentList();

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CategoryEditViewModel> GetForEditAsync(Guid id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<CategoryDeleteViewModel> GetForDeleteAsync(Guid id);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CategoryListViewModel>> GetListAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CategoryDetailsViewModel> GetDetailsAsync(Guid id);

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CategoryListViewModel> FindById(Guid id);

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        Task FillCreateViewModel(CategoryCreateViewModel viewModel);

        #endregion
    }
}