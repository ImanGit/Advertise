using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Products;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Plans
{
    /// <summary>
    /// </summary>
    public class TagPayment : BaseEntity
    {
        #region Properties

        public virtual DateTime ExpireOn { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual Tag Tag { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid TagId { get; set; }

        /// <summary>
        ///     خریدار
        /// </summary>
        public virtual User Buyer { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid BuyerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid ProductId { get; set; }

        #endregion
    }
}