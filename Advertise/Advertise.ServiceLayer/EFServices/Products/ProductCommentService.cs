using System.Data.Entity;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Advertise.ServiceLayer.Contracts.Products;
using Advertise.ViewModel.Models.Products.ProductComment;
using System;
using System.Collections.Generic;
using System.Linq;
using Advertise.DomainClasses.Entities.Products;
using EntityFramework.Extensions;

namespace Advertise.ServiceLayer.EFServices.Products
{
    public class ProductCommentService : IProductCommentService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<ProductComment> _productC;

        #endregion

        #region Ctor

        public ProductCommentService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _productC = unitOfWork.Set<ProductComment>();
        }

        #endregion

        #region Create

        public async Task CreateAsync(ProductCCreateViewModel viewModel)
        {
            var productC = _mapper.Map<ProductComment>(viewModel);
            _productC.Add(productC);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductCCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new ProductCCreateViewModel());
        }

        #endregion

        #region Edit

        public async Task EditAsync(ProductCEditViewModel viewModel)
        {
            var product = await _productC.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, product);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductCEditViewModel> GetForEditAsync(Guid id)
        {
            return await _productC
                .AsNoTracking()
                .ProjectTo<ProductCEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Read


        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<IEnumerable<ProductCListViewModel>> GetListAsync()
        {
            return await _productC
                .AsNoTracking()
                .ProjectTo<ProductCListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .ToListAsync();
        }


        public async Task<ProductCDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _productC
                .AsNoTracking()
                .ProjectTo<ProductCDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public Task<ProductCListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(ProductCCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete

        public Task DeleteAsync(ProductCDeleteViewModel viewModel)
        {
            return _productC.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<ProductCDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _productC
                .AsNoTracking()
                .ProjectTo<ProductCDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }
        #endregion

        #region Retrive
        public void GetCountAllCommentNotAccept()
        {
            throw new NotImplementedException();
        }

        public void GetAllCommentNotAccept()
        {
            throw new NotImplementedException();
        }

        public int GetAcceptCommentOperator()
        {
            throw new NotImplementedException();
        }

        public int GetAllOperatorForAcceptComment()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}