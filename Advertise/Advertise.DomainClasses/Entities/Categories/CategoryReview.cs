using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Categories
{
    public class CategoryReview : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual bool Body { get; set; }

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