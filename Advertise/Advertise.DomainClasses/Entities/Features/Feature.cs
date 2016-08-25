using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Features
{
    /// <summary>
    /// </summary>
    public class Feature : BaseEntity
    {
        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual ICollection<FeatureOrder> Orders { get; set; }

        #endregion

        #region Properties

        /// <summary>
        ///     کد سرویس
        /// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        ///     عنوان سریس
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        ///     توضیح سرویس
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        ///     مدت سرویس(یکماهه،دو ماهه و...)
        /// </summary>
        public virtual string DurationDay { get; set; }

        /// <summary>
        ///     قیمت سرویس   Rial (ريال)
        /// </summary>
        public virtual int CostRialValue { get; set; }

        /// <summary>
        ///     United States dollar	USD($)
        /// </summary>
        public virtual long CostUsdValue { get; set; }

        /// <summary>
        ///     آیا سرویس فعال است؟
        /// </summary>
        public virtual bool IsActive { get; set; }

        /// <summary>
        /// </summary>
        public virtual FeatureType Type { get; set; }

        /// <summary>
        ///     تاریخ شروع سرویس
        /// </summary>
        public virtual DateTime StartedOn { get; set; }

        /// <summary>
        ///     تاریخ پایان سرویس
        /// </summary>
        public virtual DateTime ExpiredOn { get; set; }

        #endregion
    }
}