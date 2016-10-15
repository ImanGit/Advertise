using System;

using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies ;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Advertise.ServiceLayer.Contracts.Companies;
using Advertise.ViewModel.Models.Companies.CompanyQuestionLike ;

namespace Advertise.ServiceLayer.EFServices.Companies
{
    public class CompanyQuestionLikeService : ICompanyQuestionLikeService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CompanyQuestionLike> _companyQuestionLike ;

        #endregion

        #region Ctor
        public CompanyQuestionLikeService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _companyQuestionLike = unitOfWork.Set<CompanyQuestionLike >();
        }
        #endregion

        #region Create
        public async Task CreateAsync(CompanyQuestionLikeCreateViewModel  viewModel)
        {
            var companyQuestionLike = _mapper.Map<CompanyQuestionLike>(viewModel);
            _companyQuestionLike.Add(companyQuestionLike);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyQuestionLikeCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CompanyQuestionLikeCreateViewModel());
        }

        Task<CompanyQuestionLikeEditViewModel> ICompanyQuestionLikeService.GetForEditAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Edit
        public async Task EditAsync(CompanyQuestionLikeEditViewModel  viewModel)
        {
            var category = await _companyQuestionLike.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, category);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

       
        public void EditForLikeOrUnlike()
        {
            throw new NotImplementedException();
        }

        Task<CompanyQuestionLikeCreateViewModel> ICompanyQuestionLikeService.GetForCreateAsync()
        {
            throw new NotImplementedException();
        }

      
        public void EditForFollowOrUnFollow()
        {
            throw new NotImplementedException();
        }

        public async Task<CompanyQuestionLikeEditViewModel > GetForEditAsync(Guid id)
        {
            return await _companyQuestionLike
                .AsNoTracking()
                .ProjectTo<CompanyQuestionLikeEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Retrive
        public void GetCountForques()
        {
            throw new NotImplementedException();
        }

        public int GetAlluserLikeQestion()
        {
            throw new NotImplementedException();
        }

        public bool GetLikeForUser()
        {
            throw new NotImplementedException();
        }

        public int GetCountAllLikeUser()
        {
            throw new NotImplementedException();
        }

        public int GetAllLikeUser()
        {
            throw new NotImplementedException();
        }

        #endregion
      
    }
}