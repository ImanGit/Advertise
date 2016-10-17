using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;
using System.Collections.Generic;

namespace Advertise.DomainClasses.Entities.Categories
{
    /// <summary>
    /// </summary>
    public class CategoryFollow : BaseEntity
    {
       

        #region Properties

        /// <summary>
        /// </summary>
        public virtual bool IsFollow { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual User FollowedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid FollowedById { get; set; }

        /// <summary>
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CategoryId { get; set; }
        public HashSet<CategoryFollow> Reviews { get; private set; }

        #endregion
    }
}