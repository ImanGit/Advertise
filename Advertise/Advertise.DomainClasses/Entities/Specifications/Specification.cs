using System;
using Advertise.DomainClasses.Entities.Categories;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Specifications
{
    /// <summary>
    /// </summary>
    public class Specification : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// </summary>
        public virtual SpecificationType Type { get; set; }

        /// <summary>
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// </summary>
        public virtual int Order { get; set; }

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