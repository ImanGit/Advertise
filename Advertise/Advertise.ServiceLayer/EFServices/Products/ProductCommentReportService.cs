using System.Data.Entity;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Advertise.ServiceLayer.Contracts.Products;
using Advertise.ViewModel.Models.Products.ProductCommentReport;
using System;
using System.Collections.Generic;
using System.Linq;
using Advertise.DomainClasses.Entities.Products;
using EntityFramework.Extensions;

namespace Advertise.ServiceLayer.EFServices.Products
{
    class ProductCommentReportService : IProductCommentReportService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<ProductCommentReport> _cproductCr;

        #endregion

        #region Ctor

        public ProductCommentReportService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _cproductCr = unitOfWork.Set<ProductCommentReport>();
        }

        #endregion

        #region Create

        public async Task CreateAsync(ProductCommentReportCreateViewModel viewModel)
        {
            var companyQr = _mapper.Map<ProductCommentReport>(viewModel);
            _cproductCr.Add(companyQr);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductCommentReportCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new ProductCommentReportCreateViewModel());
        }

        #endregion

        #region Edit

        public async Task EditAsync(ProductCommentReportEditViewModel viewModel)
        {
            var product = await _cproductCr.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, product);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductCommentReportEditViewModel> GetForEditAsync(Guid id)
        {
            return await _cproductCr
                .AsNoTracking()
                .ProjectTo<ProductCommentReportEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Read


        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<IEnumerable<ProductCommentReportListViewModel>> GetListAsync()
        {
            return await _cproductCr
                .AsNoTracking()
                .ProjectTo<ProductCommentReportListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .ToListAsync();
        }


        public async Task<ProductCommentReportDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _cproductCr
                .AsNoTracking()
                .ProjectTo<ProductCommentReportDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public Task<ProductCommentReportListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(ProductCommentReportCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete

        public Task DeleteAsync(ProductCommentReportDeleteViewModel viewModel)
        {
            return _cproductCr.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<ProductCommentReportDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _cproductCr
                .AsNoTracking()
                .ProjectTo<ProductCommentReportDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }


        #endregion

        #region Retrive

        public void GetReportId()
        {
            throw new NotImplementedException();
        }

        public void GetAllReportProduct()
        {
            throw new NotImplementedException();
        }

        public void GetCountAllReportProduct()
        {
            throw new NotImplementedException();
        }

        public void GetAllReportProducts()
        {
            throw new NotImplementedException();
        }

        public void GetCountAllReportProducts()
        {
            throw new NotImplementedException();
        }

        public void FindCompany()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}