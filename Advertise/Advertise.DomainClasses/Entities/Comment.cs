using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده سیستم کامنت گذاری
    /// </summary>
    public class Comment : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Comment()
        {
            Id = Guid.NewGuid();
            IsAccepted = false;
        }

        #endregion

        #region Properties

        /// <summary>
        /// متن کامنت
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// تاریخ ایجاد کامنت
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// تعداد لایکهای کامنت
        /// </summary>
        public Int32? LikedCount { get; set; }

        /// <summary>
        /// آیا کامنت از سوی اپراتور پذیرفته شده است؟
        /// </summary>
        public bool IsAccepted { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid CreateUserId { get; set; }

        /// <summary>
        /// کاربری که کامنت گذاشته 
        /// </summary>
        public virtual User CreateUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid ProductId { get; set; }

        /// <summary>
        /// کداختصاصی محصول
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid AcceptUserId { get; set; }

        /// <summary>
        /// کاربری (اپراتور)که کامنت را تائید کرده است
        /// </summary>
        public virtual User AcceptUser { get; set; }

        #endregion
    }
}
