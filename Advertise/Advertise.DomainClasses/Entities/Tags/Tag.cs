using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Tags
{
    /// <summary>
    /// </summary>
    public class Tag : BaseEntity
    {
        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual ICollection<TagOrder> Orders { get; set; }

        #endregion

        #region Properties

        /// <summary>
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
        /// </summary>
        public virtual string CostRialValue { get; set; }

        /// <summary>
        ///     United States dollar	USD($)
        /// </summary>
        public virtual long CostUsdValue { get; set; }

        /// <summary>
        /// </summary>
        public virtual string DurationDay { get; set; }

        /// <summary>
        /// </summary>
        public virtual TagType Type { get; set; }

        /// <summary>
        ///     آیا سرویس فعال است؟
        /// </summary>
        public virtual bool IsActive { get; set; }


        /// <summary>
        /// </summary>
        public virtual DateTime StartedOn { get; set; }

        /// <summary>
        /// </summary>
        public virtual DateTime ExpiredOn { get; set; }

        #endregion
    }
}