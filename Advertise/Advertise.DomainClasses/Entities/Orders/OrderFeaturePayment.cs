using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Orders;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Plans
{
    /// <summary>
    /// </summary>
    public class FeaturePayment : BaseEntity
    {
        #region Properties

        public virtual DateTime ExpireOn { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual Feature Service { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ServiceId { get; set; }

        /// <summary>
        ///     خریدار
        /// </summary>
        public virtual User Buyer { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid BuyerId { get; set; }

        #endregion
    }
}