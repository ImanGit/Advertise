using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Products
{
    /// <summary>
    /// </summary>
    public class ProductReview : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual string Body { get; set; }

        /// <summary>
        /// </summary>
        public virtual bool IsActive { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کمپانی
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ProductId { get; set; }

        #endregion
    }
}