using System.Data.Entity;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Advertise.ServiceLayer.Contracts.Products;
using Advertise.ViewModel.Models.Products;
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

        public async Task CreateAsync(ProductCommentCreateViewModel viewModel)
        {
            var productC = _mapper.Map<ProductComment>(viewModel);
            _productC.Add(productC);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductCommentCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new ProductCommentCreateViewModel());
        }

        #endregion

        #region Edit

        public async Task EditAsync(ProductCommentEditViewModel viewModel)
        {
            var product = await _productC.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, product);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductCommentEditViewModel> GetForEditAsync(Guid id)
        {
            return await _productC
                .AsNoTracking()
                .ProjectTo<ProductCommentEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Read


        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<IEnumerable<ProductCommentListViewModel>> GetListAsync()
        {
            return await _productC
                .AsNoTracking()
                .ProjectTo<ProductCommentListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .ToListAsync();
        }


        public async Task<ProductCommentDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _productC
                .AsNoTracking()
                .ProjectTo<ProductCommentDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public Task<ProductCommentListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(ProductCommentCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete

        public Task DeleteAsync(ProductCommentDeleteViewModel viewModel)
        {
            return _productC.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<ProductCommentDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _productC
                .AsNoTracking()
                .ProjectTo<ProductCommentDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
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