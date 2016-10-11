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
using Advertise.ViewModel.Models.Products.ProductReport;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.ServiceLayer.EFServices.Products
{
    class ProductReportService :IProductReportService 

    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<ProductReport> _ProductR;

        #endregion

        #region Ctor
        public ProductReportService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _ProductR = unitOfWork.Set<ProductReport>();
        }
        #endregion

        #region Create
        public async Task CreateAsync(ProductRCreateViewModel viewModel)
        {
            var productR = _mapper.Map<ProductReport>(viewModel);
            _ProductR.Add(productR);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductRCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new ProductRCreateViewModel());
        }
        #endregion

        #region Edit
        public async Task EditAsync(ProductREditViewModel viewModel)
        {
            var productR = await _ProductR.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, productR);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductREditViewModel> GetForEditAsync(Guid id)
        {
            return await _ProductR
                .AsNoTracking()
                .ProjectTo<ProductREditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        #endregion

        #region Read


        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<IEnumerable<ProductRListViewModel>> GetListAsync()
        {
            return await _ProductR
               .AsNoTracking()
               .ProjectTo<ProductRListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
               .ToListAsync();
        }


        public async Task<ProductRDetailViewModel> GetDetailsAsync(Guid id)
        {
            return await _ProductR
                .AsNoTracking()
                .ProjectTo<ProductRDetailViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public Task<ProductRListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(ProductRCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete

        public Task DeleteAsync(ProductRDeleteViewModel viewModel)
        {
            return _ProductR.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public async Task<ProductRDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _ProductR
                .AsNoTracking()
                .ProjectTo<ProductRDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }


        #endregion
    }
}
