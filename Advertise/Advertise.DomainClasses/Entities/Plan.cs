using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Plan : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Plan()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// کد سرویس
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// عنوان سریس
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// متن سرویس
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// مدت سرویس(یکماهه،دو ماهه و...)
        /// </summary>
        public string DurationDay { get; set; }

        /// <summary>
        /// قیمت سرویس
        /// </summary>
        public Int32 CostValue { get; set; }

        /// <summary>
        /// آیا سرویس فعال است؟
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// تاریخ شروع سرویس
        /// </summary>
        public DateTime FromDate { get; set; }

        /// <summary>
        /// تاریخ پایان سرویس
        /// </summary>
        public DateTime ToDate { get; set; }

        #endregion

        #region NavigationProperties


        #endregion
    }
}
