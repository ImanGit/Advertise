using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies ;
using Advertise.ServiceLayer.Contracts.Companies ;
using Advertise.ViewModel.Models.Companies ;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityFramework.Extensions;


namespace Advertise.ServiceLayer.EFServices.Companies
{
    public class CompanyService : ICompanyService
    {
        // public DbSet<Company> _c;

        #region Ctor

        /// <summary>
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="unitOfWork"></param>
        public CompanyService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _company = unitOfWork.Set<Company>();
        }

        #endregion

        #region Create
        public async Task CreateAsync(CompanyCreateViewModel viewModel)
        {
            var company = _mapper.Map<Company>(viewModel);
            _company.Add(company);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9d2b0228-4d0d-4c23-8b49-01a698857709"));
        }

        public async Task<CompanyCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CompanyCreateViewModel { Description = "" });
        }

        #endregion

        #region Edit
        public async Task EditAsync(CompanyEditViewModel viewModel)
        {
            var company = await _company.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, company);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyEditViewModel> GetForEditAsync(Guid id)
        {
            return await _company
                .AsNoTracking()
                .ProjectTo<CompanyEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }


        public bool EditForActiveOrDeActive()
        {
            throw new NotImplementedException();
        }

        public void RecoveryDeleted()
        {
            throw new NotImplementedException();
        }

        public void EditCopamanyCategory()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Company> _company;

        #endregion

        #region Delete
        public Task DeleteAsync(CompanyDeleteViewModel viewModel)
        {
            return _company.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }
        public void DeleteHard()
        {
            throw new NotImplementedException();
        }

        public async Task<CompanyDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _company
                .AsNoTracking()
                .ProjectTo<CompanyDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Retrive
        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetOneComp()
        {
            throw new NotImplementedException();
        }

        public void GetManyComp()
        {
            throw new NotImplementedException();
        }

        public void GetByDate()
        {
            throw new NotImplementedException();
        }

        public void GetCountByDate()
        {
            throw new NotImplementedException();
        }

        public void GetCompanyInCategory()
        {
            throw new NotImplementedException();
        }

        public void GetCountCompanyInCategory()
        {
            throw new NotImplementedException();
        }

        public void GetPageList()
        {
            throw new NotImplementedException();
        }

        public void GetInDb()
        {
            throw new NotImplementedException();
        }

        public int GetActive()
        {
            throw new NotImplementedException();
        }

        public int GetForSearch()
        {
            throw new NotImplementedException();
        }

        public int GetDeleted()
        {
            throw new NotImplementedException();
        }

        public int Find()
        {
            throw new NotImplementedException();
        }


        #endregion

       
        #region Read

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CompanyListViewModel >> GetListAsync()
        {
            return await _company 
                .AsNoTracking()
                .ProjectTo<CompanyListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .ToListAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CompanyDetailsViewModel > GetDetailsAsync(Guid id)
        {
            return await _company 
                .AsNoTracking()
                .ProjectTo<CompanyDetailsViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public async Task<CompanyListViewModel > FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(CompanyCreateViewModel  viewModel)
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}