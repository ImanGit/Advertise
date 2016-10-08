using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Products.ProductComment;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Products
{
    public interface IProductCommentService : IBaseService
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(ProductCCreateViewModel viewModel);
        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        Task EditAsync(ProductCEditViewModel viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(ProductCDeleteViewModel viewModel);
        #endregion

        #region Read

        Task<ProductCCreateViewModel> GetForCreateAsync();

        Task<ProductCEditViewModel> GetForEditAsync(Guid id);

        Task<ProductCDeleteViewModel> GetForDeleteAsync(Guid id);

        Task<IEnumerable<ProductCListViewModel >> GetListAsync();

        Task<ProductCDetailViewModel> GetDetailsAsync(Guid id);

        Task<ProductCListViewModel> FindById(Guid id);

        Task FillCreateViewModel(ProductCCreateViewModel viewModel);

        #endregion

        #region Retrieve

        /// <summary>
        ///     تعداد کل کامنتهایی که تائید نشدن
        /// </summary>
        void GetCountAllCommentNotAccept();

        /// <summary>
        ///     نمایش کل کامنتهایی که تائید نشدن
        /// </summary>
        void GetAllCommentNotAccept();

        /// <summary>
        ///  تائید کامنت توسط کدام اپراتور صورت گرفته
        /// </summary>
        int GetAcceptCommentOperator();

        /// <summary>
        /// نمایش کلیه اپراتورهایی که کامنتها را تائید میکنند
        /// </summary>
        /// <returns></returns>
        int GetAllOperatorForAcceptComment();

        #endregion
    }
}