using System;
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
        void Add(AddCategoryViewModel viewModel);

        #endregion

        #region Update

        /// <summary>
        /// </summary>
        Task EditAsync(EditCategoryViewModel viewModel);

        #endregion

        #region Read

        /// <summary>
        ///     گرفتن تعداد کل دسته بندی ها
        /// </summary>
        Task<int> GetCount();

        /// <summary>
        ///     گرفتن آخرین دسته بندی ها بر اساس روز
        /// </summary>
        /// <returns></returns>
        Task<int> GetLastToDay();

        /// <summary>
        /// </summary>
        Task<CategoryListViewModel> FindById(Guid id);

        #endregion

        #region Delete

        /// <summary>
        ///     پاک کردن به صورت منطقی
        /// </summary>
        Task RemoveAsync(Guid id);

        /// <summary>
        ///     پاک کردن به صورت فیزیکی
        /// </summary>
        /// <returns></returns>
        Task RemoveHard(Guid id);

        #endregion
    }
}