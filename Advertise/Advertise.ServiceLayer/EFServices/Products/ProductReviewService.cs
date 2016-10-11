using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Products ;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Advertise.ServiceLayer.Contracts.Products ;
using Advertise.ViewModel.Models.Products.ProductReview ;
using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Extensions;
using System.Data.Entity;

namespace Advertise.ServiceLayer.EFServices.Products
{
    public class ProductReviewService : IProductReviewService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<ProductReview > _productRw;

        #endregion

        #region Ctor

        public ProductReviewService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _productRw = unitOfWork.Set<ProductReview >();
        }

        #endregion

        #region Create

        public async Task CreateAsync(ProductRwCreateViewModel viewModel)
        {
            var companyr = _mapper.Map<ProductReview >(viewModel);
            _productRw.Add(companyr);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductRwCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new ProductRwCreateViewModel());
        }

        #endregion

        #region Edit

        public async Task EditAsync(ProductRwEditViewModel viewModel)
        {
            var category = await _productRw.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, category);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductRwEditViewModel> GetForEditAsync(Guid id)
        {
            return await _productRw
                .AsNoTracking()
                .ProjectTo<ProductRwEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Read


        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<IEnumerable<ProductRwListViewModel>> GetListAsync()
        {
            return await _productRw
                .AsNoTracking()
                .ProjectTo<ProductRwListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .ToListAsync();
        }


        public async Task<ProductRwDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _productRw
                .AsNoTracking()
                .ProjectTo<ProductRwDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public Task<ProductRwListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(ProductRwCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete

        public Task DeleteAsync(ProductRwDeleteViewModel viewModel)
        {
            return _productRw.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<ProductRwDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _productRw
                .AsNoTracking()
                .ProjectTo<ProductRwDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Retrive
        public void GetCountAllReviwe()
        {
            throw new NotImplementedException();
        }

        public void GetIdProductForShowReview()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}