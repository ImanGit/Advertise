using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Products;
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
        ///     آیا کاربر هشدارها را مشاهده کرده؟
        /// </summary>
        public bool IsRead { get; set; }

        /// <summary>
        /// </summary>
        public virtual string Url { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کاربر
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid UserId { get; set; }


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