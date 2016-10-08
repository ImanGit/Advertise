using System;
using Advertise.ServiceLayer.Contracts.Products;
using Advertise.ViewModel.Models.Products.ProductImage;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Products;
using Advertise.DataLayer.Context;
using AutoMapper;
using System.Data.Entity;
using System.Linq;
using AutoMapper.QueryableExtensions;
using EntityFramework.Extensions;
using System.Collections.Generic;

namespace Advertise.ServiceLayer.EFServices.Products
{
    public class ProductImageService : IProductImageService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<ProductImage> _productImage;

        #endregion

        #region Ctor
        public ProductImageService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _productImage = unitOfWork.Set<ProductImage>();
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

        public async Task EditAsync(ProductImageEditViewModel viewModel)
        {
            var productImage = await _productImage.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, productImage);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductImageEditViewModel> GetForEditAsync(Guid id)
        {
            return await _productImage
                .AsNoTracking()
                .ProjectTo<ProductImageEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }
        #endregion

        #region Create
        public async Task CreateAsync(ProductImageCreateViewModel viewModel)
        {
            var productImage = _mapper.Map<ProductImage>(viewModel);
            _productImage.Add(productImage);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductImageCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new ProductImageCreateViewModel());
        }
        #endregion

        #region Delete


        public Task DeleteAsync(ProductImageDeleteViewModel viewModel)
        {
            return _productImage.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<ProductImageDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _productImage
                .AsNoTracking()
                .ProjectTo<ProductImageDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }
        #endregion

        #region Read


        public IList<ProductImageListViewModel> GetChildList(Guid? parentId)
        {
            throw new NotImplementedException();
        }

        public IList<ProductImageListViewModel> GetParentList()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductImageListViewModel>> GetListAsync()
        {
            return await _productImage
                .AsNoTracking()
                .ProjectTo<ProductImageListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .ToListAsync();
        }
        public async Task<ProductImageDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _productImage
                .AsNoTracking()
                .ProjectTo<ProductImageDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }
        public Task<ProductImageListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(ProductImageCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public int EditOrderImageProductForComany()
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

        public int GetCountImageProductCompany()
        {
            throw new NotImplementedException();
        }

        public int GetImageProductCompany()
        {
            throw new NotImplementedException();
        }

        public int GetCountAllImageCompany()
        {
            throw new NotImplementedException();
        }

        public int GetCountImageInPlan()
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}