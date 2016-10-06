using System.Data.Entity;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Advertise.ServiceLayer.Contracts.Companies;
using Advertise.ViewModel.Models.Companies.CompanyQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Extensions;
namespace Advertise.ServiceLayer.EFServices.Companies
{
    public class CompanyQuestionService : ICompanyQuestionService
    {

        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CompanyQuestion> _companyQ;

        #endregion
        #region Ctor
        public CompanyQuestionService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _companyQ = unitOfWork.Set<CompanyQuestion>();
        }
        #endregion
        #region Create
        public async Task CreateAsync(CompanyQCreateViewModel viewModel)
        {
            var companyQ = _mapper.Map<CompanyQuestion>(viewModel);
            _companyQ.Add(companyQ);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }
        #endregion
        #region Edit
        public async Task EditAsync(CompanyQEditViewModel viewModel)
        {
            var companyQ = await _companyQ.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, companyQ);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }
        #endregion

        #region Read
        public async Task<CompanyQCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CompanyQCreateViewModel());
        }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CompanyQEditViewModel> GetForEditAsync(Guid id)
        {
            return await _companyQ
                .AsNoTracking()
                .ProjectTo<CompanyQEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public async Task<IEnumerable<CompanyQListViewModel>> GetListAsync()
        {
            return await _companyQ
               .AsNoTracking()
               .ProjectTo<CompanyQListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
               .ToListAsync();
        }

        public Task DeleteAsync(CompanyQDeleteViewModel viewModel)
        {
            return _companyQ.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }


        public void GetReportId()
        {
            throw new NotImplementedException();
        }

        public void GetAllReportCompany()
        {
            throw new NotImplementedException();
        }

        public void GetCountAllReportCompany()
        {
            throw new NotImplementedException();
        }

        public void GetAllReportCompanys()
        {
            throw new NotImplementedException();
        }

        public void GetCountAllReportCompanys()
        {
            throw new NotImplementedException();
        }

        public void FindCompany()
        {
            throw new NotImplementedException();
        }

        public async Task<CompanyQDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _companyQ
                .AsNoTracking()
                .ProjectTo<CompanyQDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public async Task<CompanyQDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _companyQ
                .AsNoTracking()
                .ProjectTo<CompanyQDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public Task<CompanyQListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(CompanyQCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }


        #endregion
        public void Create()
        {
            throw new NotImplementedException();
        }

        public bool EditForApprove()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void GetCountNotApprove()
        {
            throw new NotImplementedException();
        }

        public void GetCountApprove()
        {
            throw new NotImplementedException();
        }

        public int GetCountUnknown()
        {
            throw new NotImplementedException();
        }

        public int GetNotApprove()
        {
            throw new NotImplementedException();
        }

        public void GetApprove()
        {
            throw new NotImplementedException();
        }

        public int GetUnknown()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }
    }
}