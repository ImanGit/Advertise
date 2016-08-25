using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Paymenys
{
    /// <summary>
    /// </summary>
    public class PaymentTransaction : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     کدرهگیری که بانک میدهد
        /// </summary>
        public string ReferenceCode { get; set; }

        /// <summary>
        /// </summary>
        public long Value { get; set; }

        /// <summary>
        /// </summary>
        public bool IsSuccess { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual User PayedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid PayedById { get; set; }

        /// <summary>
        /// </summary>
        public virtual UserBudget Budget { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid BudgetId { get; set; }

        #endregion
    }
}