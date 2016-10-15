using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;
using System.Collections.Generic;

namespace Advertise.DomainClasses.Entities.Categories
{
    /// <summary>
    /// </summary>
    public class CategoryReview : BaseEntity
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
        /// </summary>
        public virtual User AuthoredBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid AuthoredById { get; set; }

        /// <summary>
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CategoryId { get; set; }
        public HashSet<CategoryReview> Reviews { get; private set; }

        #endregion
    }
}