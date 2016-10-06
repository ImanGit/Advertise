using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Companies.CompanyModerator ;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Advertise.ServiceLayer.Contracts.Companies
{
   public  interface ICompanyModeratorService : IBaseService
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(CompanyModeratorCreateViewModel  viewModel);
        #endregion


        #region Update
        /// <summary>
        /// 
        /// </summary>
        Task EditAsync(CompanyModeratorEditViewModel  viewModel);

        #endregion
        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(CompanyModeratorDeleteViewModel  viewModel);
        #endregion

        #region Retrieve
        /// <summary>
        /// تعداد کل مدریتورهای یک کمپانی
        /// </summary>
        void GetCountModeratorForComany();

        /// <summary>
        /// نمایش مدریتورهای یک کمپانی 
        /// </summary>
        void GetModeratorForComany();

       int GetCountAll();
       int GetShowAll();

        #endregion

        #region Read

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<CompanyModeratorCreateViewModel> GetForCreateAsync();



        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CompanyModeratorEditViewModel> GetForEditAsync(Guid id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<CompanyModeratorDeleteViewModel> GetForDeleteAsync(Guid id);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CompanyModeratorListViewModel>> GetListAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CompanyModeratorDetailViewModel > GetDetailsAsync(Guid id);

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CompanyModeratorListViewModel > FindById(Guid id);

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        Task FillCreateViewModel(CompanyModeratorCreateViewModel viewModel);

        #endregion
    }
}
