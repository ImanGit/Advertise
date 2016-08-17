using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Properties
{
    /// <summary>
    /// </summary>
    public class PropertyOption : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual string Value { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual Property Property { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid PropertyId { get; set; }

        #endregion
    }
}