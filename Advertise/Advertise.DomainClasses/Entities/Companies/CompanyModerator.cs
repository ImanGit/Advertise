using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Companies
{
    /// <summary>
    /// </summary>
    public class CompanyModerator : BaseEntity
    {
        #region Properties

        public virtual bool IsActive { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual User ModeratedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ModeratedById { get; set; }

        /// <summary>
        ///     کداختصاصی محصول
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CompanyId { get; set; }

        #endregion
    }
}