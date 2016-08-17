using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Categories
{
    /// <summary>
    /// </summary>
    public class CategoryFollow : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual bool IsFollowed { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual User Follower { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid FollowerId { get; set; }

        /// <summary>
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CategoryId { get; set; }

        #endregion
    }
}