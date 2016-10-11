using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies ;
using Advertise.ServiceLayer.Contracts.Companies ;
using Advertise.ViewModel.Models.Companies ;
using Advertise.ViewModel.Models.Companies.CompanyImage1 ;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityFramework.Extensions;


namespace Advertise.ServiceLayer.EFServices.Companies
{
    public class CompanyImageService : ICompanyImageService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CompanyImage > _companyImage;

        #endregion

        #region Ctor
        public CompanyImageService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _companyImage = unitOfWork.Set<CompanyImage>();
        }
        #endregion

        #region Edit

        public void EditImageProductForComany()
        {
            throw new NotImplementedException();
        }

        public int EditImageForComany()
        {
            throw new NotImplementedException();
        }

        public async Task EditAsync(CompanyImageEditViewModel viewModel)
        {
            var companyImage = await _companyImage.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, companyImage);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyImageEditViewModel> GetForEditAsync(Guid id)
        {
            return await _companyImage
                .AsNoTracking()
                .ProjectTo<CompanyImageEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }
        #endregion

        #region Create
        public async Task CreateAsync(CompanyImageCreateViewModel viewModel)
        {
            var companyImage = _mapper.Map<CompanyImage >(viewModel);
            _companyImage.Add(companyImage);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyImageCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CompanyImageCreateViewModel());
        }
        #endregion

        #region Delete


        public Task DeleteAsync(CompanyImageDeleteViewModel viewModel)
        {
            return _companyImage.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<CompanyImageDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _companyImage
                .AsNoTracking()
                .ProjectTo<CompanyImageDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }
        #endregion

        #region Read
       

        public IList<CompanyImageListViewModel> GetChildList(Guid? parentId)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyImageListViewModel> GetParentList()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CompanyImageListViewModel>> GetListAsync()
        {
            return await _companyImage
                .AsNoTracking()
                .ProjectTo<CompanyImageListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .ToListAsync();
        }
        public async Task<CompanyImageDetailsViewModel> GetDetailsAsync(Guid id)
        {
            return await _companyImage
                .AsNoTracking()
                .ProjectTo<CompanyImageDetailsViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }
        public Task<CompanyImageListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(CompanyImageCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region Retrive
        public int GetCountAllImage()
        {
            throw new NotImplementedException();
        }

        public int GetAllImage()
        {
            throw new NotImplementedException();
        }

        public int GetCountAllImageCompany()
        {
            throw new NotImplementedException();
        }

        public int GetAllImageCompany()
        {
            throw new NotImplementedException();
        }

        public int GetCountImageInPlan()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<CompanyImageListViewModel>> ICompanyImageService.GetListAsync()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}