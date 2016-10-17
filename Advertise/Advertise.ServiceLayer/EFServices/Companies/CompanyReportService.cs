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
        public async Task CreateAsync(CompanyReportCreateViewModel viewModel)
        {
            var companyr = _mapper.Map<CompanyReport>(viewModel);
            _companyr.Add(companyr);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyReportCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CompanyReportCreateViewModel());
        }
        #endregion

        #region Edit
        public async Task EditAsync(CompanyReportEditViewModel viewModel)
        {
            var category = await _companyr.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, category);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyReportEditViewModel> GetForEditAsync(Guid id)
        {
            return await _companyr
                .AsNoTracking()
                .ProjectTo<CompanyReportEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Read


        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<IEnumerable<CompanyReportListViewModel>> GetListAsync()
        {
            return await _companyr
               .AsNoTracking()
               .ProjectTo<CompanyReportListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
               .ToListAsync();
        }


        public async Task<CompanyReportDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _companyr
                .AsNoTracking()
                .ProjectTo<CompanyReportDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public Task<CompanyReportListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(CompanyReportCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete

        public Task DeleteAsync(CompanyReportDeleteViewModel viewModel)
        {
            return _companyr.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<CompanyReportDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _companyr
                .AsNoTracking()
                .ProjectTo<CompanyReportDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
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
