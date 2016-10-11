using System;
using Advertise.ServiceLayer.Contracts.Products;
using Advertise.ViewModel.Models.Products.ProductLike;
using System.Threading.Tasks;
using AutoMapper;
using Advertise.DataLayer.Context;
using System.Data.Entity;
using Advertise.DomainClasses.Entities.Products;
using AutoMapper.QueryableExtensions;

namespace Advertise.ServiceLayer.EFServices.Products
{
    public class ProductLikeService : IProductLikeService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<ProductLike> _productLike;

        #endregion

        #region Ctor
        public ProductLikeService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _productLike = unitOfWork.Set<ProductLike>();
        }
        #endregion

        #region Create
        public async Task CreateAsync(ProductLikeCreateViewModel viewModel)
        {
            var productLike = _mapper.Map<ProductLike>(viewModel);
            _productLike.Add(productLike);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductLikeCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new ProductLikeCreateViewModel());
        }
        #endregion

        #region Edit
        public async Task EditAsync(ProductLikeEditViewModel viewModel)
        {
            var category = await _productLike.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, category);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }
        public void EditForLikeOrUnlike()
        {
            throw new NotImplementedException();
        }

        public void EditForFollowOrUnFollow()
        {
            throw new NotImplementedException();
        }

        public async Task<ProductLikeEditViewModel> GetForEditAsync(Guid id)
        {
            return await _productLike
                .AsNoTracking()
                .ProjectTo<ProductLikeEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Retrive

        public int GetProductLikedCount()
        {
            throw new NotImplementedException();
        }

        public int GetProductDisLikedCount()
        {
            throw new NotImplementedException();
        }

        public int GetUserLikedCount()
        {
            throw new NotImplementedException();
        }

        public int GetUserDisLikedCount()
        {
            throw new NotImplementedException();
        }

        public bool GetUserLikeForOneProduct()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}