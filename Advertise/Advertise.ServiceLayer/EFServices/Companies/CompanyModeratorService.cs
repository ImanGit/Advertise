using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Advertise.ServiceLayer.Contracts.Companies;
using Advertise.ViewModel.Models.Companies ;
using AutoMapper;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies;
using System.Data.Entity;
using System.Linq;
using AutoMapper.QueryableExtensions;
using EntityFramework.Extensions;

namespace Advertise.ServiceLayer.EFServices.Companies
{
    public class CompanyModeratorService : ICompanyModeratorService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CompanyModerator> _companyModerator;

        #endregion

        #region Ctor
        public CompanyModeratorService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _companyModerator = unitOfWork.Set<CompanyModerator>();
        }
        #endregion

        #region Retrive
        public void GetCountModeratorForComany()
        {
            throw new NotImplementedException();
        }

        public void GetModeratorForComany()
        {
            throw new NotImplementedException();
        }

        public int GetCountAll()
        {
            throw new NotImplementedException();
        }

        public int GetShowAll()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Edit
        public async Task EditAsync(CompanyModeratorEditViewModel viewModel)
        {
            var companyImage = await _companyModerator.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, companyImage);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyModeratorEditViewModel> GetForEditAsync(Guid id)
        {
            return await _companyModerator
                .AsNoTracking()
                .ProjectTo<CompanyModeratorEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }
        #endregion

        #region Create
        public async Task CreateAsync(CompanyModeratorCreateViewModel viewModel)
        {
            var companyImage = _mapper.Map<CompanyModerator>(viewModel);
            _companyModerator.Add(companyImage);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyModeratorCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CompanyModeratorCreateViewModel());
        }
        #endregion

        #region Delete
        public Task DeleteAsync(CompanyModeratorDeleteViewModel viewModel)
        {
            return _companyModerator.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<CompanyModeratorDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _companyModerator
                .AsNoTracking()
                .ProjectTo<CompanyModeratorDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }
        #endregion

        #region Read
        public IList<CompanyModeratorListViewModel> GetChildList(Guid? parentId)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyModeratorListViewModel> GetParentList()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CompanyModeratorListViewModel>> GetListAsync()
        {
            return await _companyModerator
                .AsNoTracking()
                .ProjectTo<CompanyModeratorListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .ToListAsync();
        }
        public async Task<CompanyModeratorDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _companyModerator
                .AsNoTracking()
                .ProjectTo<CompanyModeratorDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }
        public Task<CompanyModeratorListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(CompanyModeratorCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        Task<CompanyModeratorDetailViewModel> ICompanyModeratorService.GetDetailsAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}