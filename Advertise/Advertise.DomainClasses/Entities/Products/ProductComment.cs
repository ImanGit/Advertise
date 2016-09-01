using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Enum;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Products
{
    /// <summary>
    ///     نشان دهنده سیستم کامنت گذاری
    /// </summary>
    public class ProductComment : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     متن کامنت
        /// </summary>
        public virtual string Body { get; set; }

        /// <summary>
        ///     آیا کامنت از سوی اپراتور پذیرفته شده است؟
        /// </summary>
        public virtual bool IsApproved { get; set; }

        /// <summary>
        /// </summary>
        public virtual CommentStatus Status { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کاربری که کامنت گذاشته
        /// </summary>
        public virtual User CommentedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CommentedById { get; set; }

        /// <summary>
        ///     کاربری (اپراتور)که کامنت را تائید کرده است
        /// </summary>
        public virtual User ApprovedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ApprovedById { get; set; }

        /// <summary>
        ///     کداختصاصی محصول
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ProductId { get; set; }

        #endregion
    }
}