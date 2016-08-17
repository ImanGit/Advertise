using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Users
{
    public class UserReport : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual ReportType Type { get; set; }

        /// <summary>
        /// </summary>
        public virtual string Description { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual User ReportedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ReportedById { get; set; }

        /// <summary>
        /// </summary>
        public virtual User ReportedFor { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ReportedForId { get; set; }

        #endregion
    }
}