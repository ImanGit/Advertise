using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده بودجه حساب مالی کاربر
    /// </summary>
    public class Budget : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Budget()
        {
            Id = Guid.NewGuid();
            RemainValue = 0;
        }

        #endregion

        #region Properties

        /// <summary>
        /// بودجه باقی مانده حساب مالی کاربر
        /// </summary>
        public Int32 RemainValue { get; set; }

        /// <summary>
        /// افزایش و کاهش حساب مالی کاربر
        /// </summary>
        public Int32 IncDecValue { get; set; }

        /// <summary>
        /// کدرهگیری که بانک میدهد
        /// </summary>
        public string ReffrenceCode { get; set; }

        /// <summary>
        /// زمان انجام تغییر حساب مالی کاربری
        /// </summary>
        public DateTime CreateDate { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// کد اختصاصی کاربر
        /// </summary>
        public virtual User User { get; set; }

        #endregion
    }
}
