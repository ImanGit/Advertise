using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Companies.CompanySocial ;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanySocialService :IBaseService 
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(CompanySocialCreateViewModel viewModel);
        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        Task EditAsync(CompanySocialEditViewModel   viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(CompanySocialDeleteViewModel viewModel);
        #endregion

        #region Retrieve
        /// <summary>
        /// 
        /// </summary>
        long GetCountAll();

        int GetCountTwitter();

        int GetCountFaceBook();

        int GetCountGooglePlus();

        int GetCountYoutube();

        int GetCountAllSocialComany();

        #endregion

        #region Read

        Task<CompanySocialCreateViewModel> GetForCreateAsync();

        Task<CompanySocialEditViewModel> GetForEditAsync(Guid id);

        Task<CompanySocialDeleteViewModel> GetForDeleteAsync(Guid id);

        Task<IEnumerable<CompanySocialListViewModel>> GetListAsync();

        Task<CompanySocialDetailViewModel> GetDetailsAsync(Guid id);

        Task<CompanySocialListViewModel> FindById(Guid id);

        Task FillCreateViewModel(CompanySocialCreateViewModel viewModel);

        #endregion
    }
}