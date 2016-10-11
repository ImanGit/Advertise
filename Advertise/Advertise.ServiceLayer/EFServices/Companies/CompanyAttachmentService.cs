using System;
using Advertise.ServiceLayer.Contracts.Companies;
using AutoMapper;
using System.Threading.Tasks;
using Advertise.ViewModel.Models.Companies.CompanyAttachment;
using System.Collections.Generic;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies;
using System.Data.Entity;
using AutoMapper.QueryableExtensions;
using System.Linq;
using EntityFramework.Extensions;

namespace Advertise.ServiceLayer.EFServices.Companies
{
    public class CompanyAttachmentService : ICompanyAttachmentService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CompanyAttachment> _companyAttachment;

        #endregion

        #region Ctor
        public CompanyAttachmentService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _companyAttachment = unitOfWork.Set<CompanyAttachment>();
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

        public async Task EditAsync(CompanyAttachmentEditViewModel viewModel)
        {
            var companyAttachment = await _companyAttachment.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, companyAttachment);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyAttachmentEditViewModel> GetForEditAsync(Guid id)
        {
            return await _companyAttachment
                .AsNoTracking()
                .ProjectTo<CompanyAttachmentEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }
        #endregion

        #region Create
        public async Task CreateAsync(CompanyAttachmentCreateViewModel viewModel)
        {
            var companyAttachment = _mapper.Map<CompanyAttachment>(viewModel);
            _companyAttachment.Add(companyAttachment);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyAttachmentCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CompanyAttachmentCreateViewModel());
        }
        #endregion

        #region Delete


        public Task DeleteAsync(CompanyAttachmentDeleteViewModel viewModel)
        {
            return _companyAttachment.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<CompanyAttachmentDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _companyAttachment
                .AsNoTracking()
                .ProjectTo<CompanyAttachmentDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }
        #endregion

        #region Read


        public IList<CompanyAttachmentListViewModel> GetChildList(Guid? parentId)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyAttachmentListViewModel> GetParentList()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CompanyAttachmentListViewModel>> GetListAsync()
        {
            return await _companyAttachment
                .AsNoTracking()
                .ProjectTo<CompanyAttachmentListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .ToListAsync();
        }
        public async Task<CompanyAttachmentDetailsViewModel> GetDetailsAsync(Guid id)
        {
            return await _companyAttachment
                .AsNoTracking()
                .ProjectTo<CompanyAttachmentDetailsViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }
        public Task<CompanyAttachmentListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(CompanyAttachmentCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region Retrive

        public void Get()
        {
            throw new NotImplementedException();
        }

        public int GetCountCompanyAttach()
        {
            throw new NotImplementedException();
        }

        public int GetOneCompanyAttach()
        {
            throw new NotImplementedException();
        }

        public int GetCompanyAttach()
        {
            throw new NotImplementedException();
        }

        public int GetAllCount()
        {
            throw new NotImplementedException();
        }

        public int GetAttachmentByCode()
        {
            throw new NotImplementedException();
        }

        public int Find()
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}