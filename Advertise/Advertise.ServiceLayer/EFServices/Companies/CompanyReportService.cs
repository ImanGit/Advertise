using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Advertise.ServiceLayer.Contracts.Companies;
using Advertise.ViewModel.Models.Companies.CompanyReport;
using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Extensions;
using System.Data.Entity;

namespace Advertise.ServiceLayer.EFServices.Companies
{
    class CompanyReportService : ICompanyReportService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CompanyReport> _companyr;

        #endregion

        #region Ctor
        public CompanyReportService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _companyr = unitOfWork.Set<CompanyReport>();
        }
        #endregion

        #region Create
        public async Task CreateAsync(CompanyRCreateViewModel viewModel)
        {
            var companyr = _mapper.Map<CompanyReport>(viewModel);
            _companyr.Add(companyr);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyRCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CompanyRCreateViewModel());
        }
        #endregion

        #region Edit
        public async Task EditAsync(CompanyREditViewModel viewModel)
        {
            var category = await _companyr.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, category);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyREditViewModel> GetForEditAsync(Guid id)
        {
            return await _companyr
                .AsNoTracking()
                .ProjectTo<CompanyREditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Read


        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<IEnumerable<CompanyRListViewModel>> GetListAsync()
        {
            return await _companyr
               .AsNoTracking()
               .ProjectTo<CompanyRListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
               .ToListAsync();
        }


        public async Task<CompanyRDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _companyr
                .AsNoTracking()
                .ProjectTo<CompanyRDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public Task<CompanyRListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(CompanyRCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete

        public Task DeleteAsync(CompanyRDeleteViewModel viewModel)
        {
            return _companyr.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<CompanyRDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _companyr
                .AsNoTracking()
                .ProjectTo<CompanyRDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }


        #endregion

        #region Retrive

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
        #endregion
    }
}
