using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Advertise.ServiceLayer.Contracts.Companies;
using Advertise.ViewModel.Models.Companies.CompanySocial;
using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Extensions;
using System.Data.Entity;

namespace Advertise.ServiceLayer.EFServices.Companies
{
    public class CompanySocialService : ICompanySocialService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CompanySocial> _companySocial;

        #endregion

        #region Ctor

        public CompanySocialService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _companySocial = unitOfWork.Set<CompanySocial>();
        }

        #endregion

        #region Create

        public async Task CreateAsync(CompanySocialCreateViewModel viewModel)
        {
            var companyr = _mapper.Map<CompanySocial>(viewModel);
            _companySocial.Add(companyr);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanySocialCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CompanySocialCreateViewModel());
        }

        #endregion

        #region Edit

        public async Task EditAsync(CompanySocialEditViewModel viewModel)
        {
            var category = await _companySocial.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, category);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanySocialEditViewModel> GetForEditAsync(Guid id)
        {
            return await _companySocial
                .AsNoTracking()
                .ProjectTo<CompanySocialEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Read


        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<IEnumerable<CompanySocialListViewModel>> GetListAsync()
        {
            return await _companySocial
                .AsNoTracking()
                .ProjectTo<CompanySocialListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .ToListAsync();
        }


        public async Task<CompanySocialDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _companySocial
                .AsNoTracking()
                .ProjectTo<CompanySocialDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public Task<CompanySocialListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(CompanySocialCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete

        public Task DeleteAsync(CompanySocialDeleteViewModel viewModel)
        {
            return _companySocial.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<CompanySocialDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _companySocial
                .AsNoTracking()
                .ProjectTo<CompanySocialDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }


        #endregion

        #region Retrive
        public long GetCountAll()
        {
            throw new NotImplementedException();
        }

        public int GetCountTwitter()
        {
            throw new NotImplementedException();
        }

        public int GetCountFaceBook()
        {
            throw new NotImplementedException();
        }

        public int GetCountGooglePlus()
        {
            throw new NotImplementedException();
        }

        public int GetCountYoutube()
        {
            throw new NotImplementedException();
        }

        public int GetCountAllSocialComany()
        {
            throw new NotImplementedException();
        }




        #endregion
    }
}