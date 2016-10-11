using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Products.ProductVisit;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Products
{
    public interface IProductVisitService : IBaseService
    {
        #region Create

        Task CreateAsync(ProductVisitCreateViewModel viewModel);
        Task<ProductVisitCreateViewModel> GetForCreateAsync();
        #endregion

        #region Retrieve

        /// <summary>
        /// بازدید کل محصول
        /// </summary>
        int GetCountAllVisit();

        /// <summary>
        /// تعداد بازدیدهای امروز
        /// </summary>
        /// <returns></returns>
        int GetCountForToday();

        /// <summary>
        /// تعداد بازدیدهای یک ماه گذشته
        /// </summary>
        /// <returns></returns>
        int GetCountForMonth();


        #endregion
    }
}