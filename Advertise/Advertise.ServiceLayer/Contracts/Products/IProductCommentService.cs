using Advertise.ServiceLayer.Contracts.Common;

namespace Advertise.ServiceLayer.Contracts.Products
{
    public interface IProductCommentService : IBaseService
    {
        #region Create

        /// <summary>
        /// </summary>
        void Create();

        #endregion

        #region Delete

        /// <summary>
        /// </summary>
        void Delete();

        #endregion

        #region Update

        /// <summary>
        ///     اصلاح محتویات کامنت توسط کاربر(فیلد مربوط به Approve باید فالس بشه که بعد اپراتور تائیدش کنه
        /// </summary>
        void EditContentCommentForUser();

        /// <summary>
        ///     ویرایش متن کامنت توسط اپراتور
        /// </summary>
        void EditContentCommentForOperator();

        /// <summary>
        ///     تائید کامنت جهت نمایش در سایت توسط اپراتور
        /// </summary>
        void EditCommentForAccept();

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