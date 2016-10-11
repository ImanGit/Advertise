using System;
using Advertise.ServiceLayer.Contracts.Products;
using AutoMapper;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities .Products ;
using System.Threading.Tasks;
using Advertise.ViewModel.Models.Products.ProductVisit;
using System.Data.Entity;

namespace Advertise.ServiceLayer.EFServices.Products
{
    public class ProductVisitService : IProductVisitService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<ProductVisit> _productVisit;

        #endregion

        #region Ctor

        public ProductVisitService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _productVisit = unitOfWork.Set<ProductVisit>();
        }

        #endregion

        #region Create

        public async Task CreateAsync(ProductVisitCreateViewModel viewModel)
        {
            var productv = _mapper.Map<ProductVisit>(viewModel);
            _productVisit.Add(productv);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<ProductVisitCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new ProductVisitCreateViewModel());
        }

        #endregion

        #region Retrive
        public int GetCountAllVisit()
        {
            throw new NotImplementedException();
        }

        public int GetCountForToday()
        {
            throw new NotImplementedException();
        }

        public int GetCountForMonth()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}