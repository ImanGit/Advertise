using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Companies
{
    /// <summary>
    ///     نشان دهنده علاقه مندی ها
    /// </summary>
    public class CompanyFollow : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual bool IsFollow { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کاربر
        /// </summary>
        public virtual User FollowedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid FollowedById { get; set; }

        /// <summary>
        ///     کد اختصاصی شرکت
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CompanyId { get; set; }

        #endregion
    }
}