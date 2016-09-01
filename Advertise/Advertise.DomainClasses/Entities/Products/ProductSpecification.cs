using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Specifications;

namespace Advertise.DomainClasses.Entities.Products
{
    /// <summary>
    ///     نشان دهنده مقادیر فیلدها
    /// </summary>
    public class ProductSpecification : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual string Value { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ProductId { get; set; }

        /// <summary>
        /// </summary>
        public virtual Specification Specification { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid SpecificationId { get; set; }

        #endregion
    }
}