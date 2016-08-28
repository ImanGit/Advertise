using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Enum;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Products
{
    /// <summary>
    /// </summary>
    public class ProductShare : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual bool IsShare { get; set; }

        /// <summary>
        /// </summary>
        public virtual ShareType Type { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual User SharedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid SharedById { get; set; }

        /// <summary>
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ProductId { get; set; }

        #endregion
    }
}