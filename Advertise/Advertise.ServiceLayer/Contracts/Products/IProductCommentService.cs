using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Products;
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
        Task CreateAsync(ProductCommentCreateViewModel viewModel);
        #endregion

        #region Update
        /// <summary>
        /// 
        /// </summary>
        Task EditAsync(ProductCommentEditViewModel viewModel);

        #endregion

        #region Delete
        /// <summary>
        /// 
        /// </summary>
        Task DeleteAsync(ProductCommentDeleteViewModel viewModel);
        #endregion

        #region Read

        Task<ProductCommentCreateViewModel> GetForCreateAsync();

        Task<ProductCommentEditViewModel> GetForEditAsync(Guid id);

        Task<ProductCommentDeleteViewModel> GetForDeleteAsync(Guid id);

        Task<IEnumerable<ProductCommentListViewModel >> GetListAsync();

        Task<ProductCommentDetailViewModel> GetDetailsAsync(Guid id);

        Task<ProductCommentListViewModel> FindById(Guid id);

        Task FillCreateViewModel(ProductCommentCreateViewModel viewModel);

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