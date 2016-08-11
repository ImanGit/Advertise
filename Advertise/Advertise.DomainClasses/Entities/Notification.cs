using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده هشدار
    /// </summary>
    public class Notification : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Notification()
        {
            Id = Guid.NewGuid();
            IsViewed = false;
        }

        #endregion

        #region Properties

        /// <summary>
        /// آیا کاربر هشدارها را مشاهده کرده؟
        /// </summary>
        public bool IsViewed { get; set; }

        /// <summary>
        /// زمان ارسال هشدار
        /// </summary>
        public DateTime CreateDate { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid UserId { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid ProductId { get; set; }

        /// <summary>
        /// کداختصاصی محصول
        /// </summary>
        public virtual Product Product { get; set; }

        #endregion
    }
}
