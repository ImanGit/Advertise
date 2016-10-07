using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Advertise.ServiceLayer.Contracts.Companies;
using Advertise.ViewModel.Models.Companies.CompanyReview ;
using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Extensions;
using System.Data.Entity;

namespace Advertise.ServiceLayer.EFServices.Companies
{
    public class CompanyReviewService : ICompanyReviewService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CompanyReview> _companyReview;

        #endregion

        #region Ctor

        public CompanyReviewService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _companyReview = unitOfWork.Set<CompanyReview>();
        }

        #endregion

        #region Create

        public async Task CreateAsync(CompanyReviewCreateViewModel viewModel)
        {
            var companyr = _mapper.Map<CompanyReview>(viewModel);
            _companyReview.Add(companyr);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyReviewCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CompanyReviewCreateViewModel());
        }

        #endregion

        #region Edit

        public async Task EditAsync(CompanyReviewEditViewModel viewModel)
        {
            var category = await _companyReview.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, category);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyReviewEditViewModel> GetForEditAsync(Guid id)
        {
            return await _companyReview
                .AsNoTracking()
                .ProjectTo<CompanyReviewEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Read


        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<IEnumerable<CompanyReviewListViewModel>> GetListAsync()
        {
            return await _companyReview
                .AsNoTracking()
                .ProjectTo<CompanyReviewListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .ToListAsync();
        }


        public async Task<CompanyReviewDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _companyReview
                .AsNoTracking()
                .ProjectTo<CompanyReviewDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public Task<CompanyReviewListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(CompanyReviewCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete

        public Task DeleteAsync(CompanyReviewDeleteViewModel viewModel)
        {
            return _companyReview.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<CompanyReviewDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _companyReview
                .AsNoTracking()
                .ProjectTo<CompanyReviewDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }




        #endregion

        #region Retrive
        public void GetCountAllReviwe()
        {
            throw new NotImplementedException();
        }

        public void GetIdCompanyForShowReview()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}