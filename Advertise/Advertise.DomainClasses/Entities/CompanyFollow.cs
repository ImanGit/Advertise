using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Enum;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده علاقه مندی ها
    /// </summary>
    public class CompanyFollow : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public CompanyFollow()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// تاریخ ثبت دسته علاقه مندی
        /// </summary>
        public DateTime RegisterDate { get; set; }

       

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid UserId { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر
        /// </summary>
        public virtual User User { get; set; }

       /// <summary>
        /// 
        /// </summary>
        public virtual Guid CompanyId { get; set; }

        /// <summary>
        /// کد اختصاصی شرکت
        /// </summary>
        public virtual Company Company { get; set; }

        #endregion
    }
}
