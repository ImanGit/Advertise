using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Paymenys
{
    /// <summary>
    /// </summary>
    public class Payment : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual PaymentStatus Status { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual ICollection<PaymentTransaction> Transactions { get; set; }

        #endregion
    }
}