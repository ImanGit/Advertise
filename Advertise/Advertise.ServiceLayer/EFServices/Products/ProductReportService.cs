using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Extensions;
using System.Data.Entity;
using Advertise.ServiceLayer.Contracts.Products;
using Advertise.ViewModel.Models.Products;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.ServiceLayer.EFServices.Products
{
    class ProductReporteportService :IProductReportService 

    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<ProductReport> _productReport;

        #endregion

        #region Ctor
        public ProductReporteportService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _productReport = unitOfWork.Set<ProductReport>();
        }
        #endregion

        #region Create
        public async Task CreateAsync(ProductReportCreateViewModel viewModel)
        {
            var productReport = _mapper.Map<ProductReport>(viewModel);
            _productReport.Add(productReport);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductReportCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new ProductReportCreateViewModel());
        }
        #endregion

        #region Edit
        public async Task EditAsync(ProductReportEditViewModel viewModel)
        {
            var ProductReport = await _productReport.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, ProductReport);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductReportEditViewModel> GetForEditAsync(Guid id)
        {
            return await _productReport
                .AsNoTracking()
                .ProjectTo<ProductReportEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Read


        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<IEnumerable<ProductReportListViewModel>> GetListAsync()
        {
            return await _productReport
               .AsNoTracking()
               .ProjectTo<ProductReportListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
               .ToListAsync();
        }


        public async Task<ProductReportDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _productReport
                .AsNoTracking()
                .ProjectTo<ProductReportDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public Task<ProductReportListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(ProductReportCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete

        public Task DeleteAsync(ProductReportDeleteViewModel viewModel)
        {
            return _productReport.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<ProductReportDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _productReport
                .AsNoTracking()
                .ProjectTo<ProductReportDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }


        #endregion
    }
}
