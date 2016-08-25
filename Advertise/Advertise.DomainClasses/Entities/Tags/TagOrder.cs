using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Products;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Tags
{
    /// <summary>
    /// </summary>
    public class TagOrder : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual DateTime ExpiredOn { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     خریدار
        /// </summary>
        public virtual User OrderedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid OrderedById { get; set; }

        /// <summary>
        /// </summary>
        public virtual UserBudget UserBudget { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid UserBudgetId { get; set; }

        /// <summary>
        /// </summary>
        public virtual Tag Tag { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid TagId { get; set; }

        /// <summary>
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ProductId { get; set; }

        #endregion
    }
}