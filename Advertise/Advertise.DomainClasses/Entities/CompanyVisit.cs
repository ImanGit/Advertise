using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;


namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده دیده شدن کمپانی
    /// </summary>
    public class CompanyVisit : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public CompanyVisit()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// تاریخ ثبت دسته علاقه مندی
        /// </summary>
        public DateTime CreateDate { get; set; }



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
