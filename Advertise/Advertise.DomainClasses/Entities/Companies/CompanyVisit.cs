using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Companies
{
    /// <summary>
    ///     نشان دهنده دیده شدن کمپانی
    /// </summary>
    public class CompanyVisit : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual bool IsVisited { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کاربر
        /// </summary>
        public virtual User Visitor { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid VisitorId { get; set; }

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