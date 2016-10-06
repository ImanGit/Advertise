using System;

using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Advertise.ServiceLayer.Contracts.Companies;
using Advertise.ViewModel.Models.Companies.CompanyFollow;

namespace Advertise.ServiceLayer.EFServices.Companies
{
    public class CompanyFollowService : ICompanyFollowService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CompanyFollow > _companyFollow;

        #endregion

        #region Ctor
        public CompanyFollowService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _companyFollow = unitOfWork.Set<CompanyFollow>();
        }
        #endregion

        #region Create
        public async Task CreateAsync(CompanyFollowCreateViewModel viewModel)
        {
            var companyFollow = _mapper.Map<CompanyFollow>(viewModel);
            _companyFollow.Add(companyFollow);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }
        #endregion

        #region Edit
        public async Task EditAsync(CompanyFollowEditViewModel viewModel)
        {
            var category = await _companyFollow.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, category);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public void EditForFollowOrUnFollow()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Read
        public async Task<CompanyFollowCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CompanyFollowCreateViewModel());
        }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CompanyFollowEditViewModel> GetForEditAsync(Guid id)
        {
            return await _companyFollow
                .AsNoTracking()
                .ProjectTo<CompanyFollowEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public async Task<IEnumerable<CompanyFollowListViewModel>> GetListAsync()
        {
            return await _companyFollow
               .AsNoTracking()
               .ProjectTo<CompanyFollowListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
               .ToListAsync();
        }

        #endregion

        #region Retrive
        public int GetCountAll()
        {
            throw new NotImplementedException();
        }

        public int GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetConutFollowerForOneCompany()
        {
            throw new NotImplementedException();
        }

        public int GetFollowerForOneCompany()
        {
            throw new NotImplementedException();
        }

        public int GetUserforFollowCompany()
        {
            throw new NotImplementedException();
        }

        public int GetCountAllFollowerUser()
        {
            throw new NotImplementedException();
        }

        public int GetAllFollowerUser()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}