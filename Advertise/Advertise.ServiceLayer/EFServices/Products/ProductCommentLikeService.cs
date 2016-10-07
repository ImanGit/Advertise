using System;
using System.Data.Entity;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Products ;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Advertise.ServiceLayer.Contracts.Companies;
using Advertise.ServiceLayer.Contracts.Products;
using Advertise.ViewModel.Models.Products.ProductCommentLike ;

namespace Advertise.ServiceLayer.EFServices.Products
{
    public class ProductCommentLikeService :IProductCommentLikeService 
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<ProductCommentLike > _productCommentLike;

        #endregion

        #region Ctor
        public ProductCommentLikeService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _productCommentLike = unitOfWork.Set<ProductCommentLike>();
        }
        #endregion

        #region Create
        public async Task CreateAsync(ProductClCreateViewModel  viewModel)
        {
            var productCommentLike = _mapper.Map<ProductCommentLike>(viewModel);
            _productCommentLike.Add(productCommentLike);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductClCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new ProductClCreateViewModel());
        }
        #endregion

        #region Edit
        public async Task EditAsync(ProductClEditViewModel  viewModel)
        {
            var category = await _productCommentLike.FirstAsync(model => model.Id == viewModel.Id);
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

        public async Task<ProductClEditViewModel> GetForEditAsync(Guid id)
        {
            return await _productCommentLike
                .AsNoTracking()
                .ProjectTo<ProductClEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }


        #endregion

        #region Retrive
        public int GetCommentLikedCount()
        {
            throw new NotImplementedException();
        }

        public int GetCommentDisLikedCount()
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

        public bool GetUserLikeForOneComment()
        {
            throw new NotImplementedException();
        }

        public void GetAlluserLikeForOneProduct()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}