using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Enum;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Public
{
    /// <summary>
    /// </summary>
    public class Rating : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual RateStatus Status { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual User RatedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid RatedById { get; set; }

        #endregion
    }
}