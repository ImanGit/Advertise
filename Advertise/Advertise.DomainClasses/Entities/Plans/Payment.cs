using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Plans
{
    /// <summary>
    ///     نشان دهنده نحوه پرداخت
    /// </summary>
    public class Payment : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     شروع تاریخ اعتبار پرداخت
        /// </summary>
        public DateTime StartOn { get; set; }

        /// <summary>
        ///     پایان تاریخ اعتبار پرداخت
        /// </summary>
        public DateTime ExpireOn { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual Guid PlanId { get; set; }

        /// <summary>
        ///     کد اختصاصی سرویس خریداری شده
        /// </summary>
        public virtual Plan Plan { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid UserId { get; set; }

        /// <summary>
        ///     کاربری که کامنت گذاشته
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid BudgetId { get; set; }

        /// <summary>
        ///     کد اختصاصی بودجه
        /// </summary>
        public virtual Budget Budget { get; set; }

        #endregion
    }
}