using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده نحوه پرداخت
    /// </summary>
    public class Payment : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Payment()
        {
            Id = Guid.NewGuid();

        }

        #endregion

        #region Properties

        /// <summary>
        /// تاریخ پرداخت
        /// </summary>
        public DateTime RegisterDate { get; set; }

        /// <summary>
        ///شروع تاریخ اعتبار پرداخت
        /// </summary>
        public DateTime FromDate { get; set; }

        /// <summary>
        /// پایان تاریخ اعتبار پرداخت
        /// </summary>
        public DateTime ToDate { get; set; }
        #endregion

        #region NavigationProperties

        /// <summary>
        /// کد اختصاصی سرویس خریداری شده
        /// </summary>
        public virtual Service Service { get; set; }

        /// <summary>
        /// کاربری که کامنت گذاشته
        /// </summary>
        public virtual User  User { get; set; }

        /// <summary>
        /// کد اختصاصی بودجه
        /// </summary>
        public virtual Budget Budget { get; set; }

        #endregion
    }
}
