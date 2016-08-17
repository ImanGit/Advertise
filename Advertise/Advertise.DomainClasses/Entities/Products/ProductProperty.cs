using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Properties;

namespace Advertise.DomainClasses.Entities.Products
{
    /// <summary>
    ///     نشان دهنده مقادیر فیلدها
    /// </summary>
    public class ProductProperty : BaseEntity
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
        public virtual Property Property { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid PropertyId { get; set; }

        #endregion
    }
}