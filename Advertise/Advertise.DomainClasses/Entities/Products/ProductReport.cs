using System;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Products
{
    /// <summary>
    /// </summary>
    public class ProductReport
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
        public virtual User Reporter { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ReporterId { get; set; }

        /// <summary>
        /// </summary>
        public virtual Product ReportedFor { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ReportedForId { get; set; }

        #endregion
    }
}