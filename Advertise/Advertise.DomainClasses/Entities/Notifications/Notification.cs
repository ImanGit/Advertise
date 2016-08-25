using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    ///     نشان دهنده هشدار
    /// </summary>
    public class Notification : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     یک اطلاع رسانی خوانده شده است یا خیر
        /// </summary>
        public bool IsRead { get; set; }

        /// <summary>
        ///     کاربر با کلیک بر روی آن به صفحه‌ی خاصی هدایت شود
        /// </summary>
        public virtual string Url { get; set; }

        /// <summary>
        /// </summary>
        public virtual string Message { get; set; }

        /// <summary>
        /// </summary>
        public virtual DateTime? ReadOn { get; set; }

        /// <summary>
        ///     مشخص کننده‌ی نوع اطلاع رسانی
        /// </summary>
        public virtual NotificationType Type { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کاربر
        /// </summary>
        public virtual User Owner { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid OwnerId { get; set; }

        #endregion
    }
}