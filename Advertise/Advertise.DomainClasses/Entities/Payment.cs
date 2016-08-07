using System;
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
        public DateTime CreateDate { get; set; }

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
        /// 
        /// </summary>
        public Guid PlanId { get; set; }

        /// <summary>
        /// کد اختصاصی سرویس خریداری شده
        /// </summary>
        public Plan Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// کاربری که کامنت گذاشته
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid BudgetId { get; set; }

        /// <summary>
        /// کد اختصاصی بودجه
        /// </summary>
        public Budget Budget { get; set; }

        #endregion
    }
}
