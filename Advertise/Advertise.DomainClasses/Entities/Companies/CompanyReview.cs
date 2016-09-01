using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Companies
{
    /// <summary>
    /// </summary>
    public class CompanyReview : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual string Body { get; set; }

        /// <summary>
        /// فعال یا غیرفعال بودن
        /// </summary>
        public virtual bool Active { get; set; }
        
        

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کمپانی
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CompanyId { get; set; }

        /// <summary>
        ///     کاربر ثبت کننده ی نقد و بررسی
        /// </summary>
        public virtual User Owner { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid OwnerId { get; set; }

        /// <summary>
        ///     کاربری که نقد و بررسی را تائید کرده است
        /// </summary>
        public virtual User Approver { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ApproverId { get; set; }


        #endregion
    }
}