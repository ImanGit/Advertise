using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Features
{
    /// <summary>
    /// </summary>
    public class FeatureOrder : BaseEntity
    {
        #region Properties

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
        public virtual Feature Feature { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid FeatureId { get; set; }

        #endregion
    }
}