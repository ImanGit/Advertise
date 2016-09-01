using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Enum;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Products
{
    /// <summary>
    /// </summary>
    public class ProductCommentReport : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual ReportType Type { get; set; }

        /// <summary>
        /// </summary>
        public virtual string Reason { get; set; }

        /// <summary>
        /// </summary>
        public virtual bool IsRead { get; set; }

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
        public virtual ProductComment ReportedFor { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ReportedForId { get; set; }

        #endregion
    }
}