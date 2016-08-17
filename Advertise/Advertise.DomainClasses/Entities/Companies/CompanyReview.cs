using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Companies
{
    /// <summary>
    /// 
    /// </summary>
    public class CompanyReview : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual string Body { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کمپانی
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CompanyId { get; set; }

        #endregion
    }
}