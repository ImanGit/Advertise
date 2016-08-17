using System;
using Advertise.DomainClasses.Entities.Categories;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Properties
{
    /// <summary>
    /// </summary>
    public class Property : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// </summary>
        public PropertyType PropertyType { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CategoryId { get; set; }

        #endregion
    }
}