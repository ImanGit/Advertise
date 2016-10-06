using System.Data.Entity;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Advertise.ServiceLayer.Contracts.Companies;
using Advertise.ViewModel.Models.Companies.CompanyQuestionReport;
using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Extensions;

namespace Advertise.ServiceLayer.EFServices.Companies
{
    class CompanyQuestionReportService :ICompanyQuestionReportService 
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CompanyQuestionReport> _companyQr;

        #endregion
        #region Ctor
        public CompanyQuestionReportService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _companyQr = unitOfWork.Set<CompanyQuestionReport >();
        }
        #endregion
        #region Create
        public async Task CreateAsync(CompanyQrCreateViewModel viewModel)
        {
            var companyQr = _mapper.Map<CompanyQuestionReport>(viewModel);
            _companyQr.Add(companyQr );
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }
        #endregion
        #region Edit
        public async Task EditAsync(CompanyQrEditViewModel viewModel)
        {
            var category = await _companyQr.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, category);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }
        #endregion

        #region Read
        public async Task<CompanyQrCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CompanyQrCreateViewModel());
        }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CompanyQrEditViewModel> GetForEditAsync(Guid id)
        {
            return await _companyQr
                .AsNoTracking()
                .ProjectTo<CompanyQrEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public async Task<IEnumerable<CompanyQrListViewModel >> GetListAsync()
        {
            return await _companyQr
               .AsNoTracking()
               .ProjectTo<CompanyQrListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
               .ToListAsync();
        }

        public Task DeleteAsync(CompanyQrDeleteViewModel viewModel)
        {
            return _companyQr.Where(model => model.Id == viewModel.Id).DeleteAsync();
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

        public async Task<CompanyQrDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _companyQr
                .AsNoTracking()
                .ProjectTo<CompanyQrDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public async Task<CompanyQrDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _companyQr
                .AsNoTracking()
                .ProjectTo<CompanyQrDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public Task<CompanyQrListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(CompanyQrCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }
       

        #endregion
    }
}
