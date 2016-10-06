using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Advertise.ServiceLayer.Contracts.Companies;
using Advertise.ViewModel.Models.Companies.CompanyImage1;
using AutoMapper;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies;
using System.Data.Entity;

namespace Advertise.ServiceLayer.EFServices.Companies
{
    public class CompanyImageService : ICompanyImageService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CompanyImage > _companyImage;

        #endregion

        public CompanyImageService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _companyImage = unitOfWork.Set<CompanyImage>();
        }
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void EditImageProductForComany()
        {
            throw new NotImplementedException();
        }

        public int EditImageForComany()
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

        public void Get()
        {
            throw new NotImplementedException();
        }
        #region Create
        public async Task CreateAsync(CompanyImageCreateViewModel viewModel)
        {
            var companyImage = _mapper.Map<CompanyImage >(viewModel);
            _companyImage.Add(companyImage);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }
        #endregion
        #region Edit
        public async Task EditAsync(CompanyImageEditViewModel viewModel)
        {
            var companyImage = await _companyImage.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, companyImage);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }
        #endregion

        public Task DeleteAsync(CompanyImageDeleteViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task<CompanyImageCreateViewModel> GetForCreateAsync()
        {
            throw new NotImplementedException();
        }

        public IList<CompanyImageListViewModel> GetChildList(Guid? parentId)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyImageListViewModel> GetParentList()
        {
            throw new NotImplementedException();
        }

        public Task<CompanyImageEditViewModel> GetForEditAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CompanyImageDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CompanyImageListViewModel>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CompanyImageDetailsViewModel> GetDetailsAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CompanyImageListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(CompanyImageCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

       
    }
}