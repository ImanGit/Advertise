using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// شان دهنده علاقه مندی ها
    /// </summary>
    public class Follow : BaseEntity 
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Follow()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// تاریخ ثبت دسته علاقه مندی
        /// </summary>
        public DateTime RegisterDate { get; set; }

        /// <summary>
        /// نوع علاقه مندی(شرکت یا دسته محصول)
        /// </summary>
        public Int32 FollowType { get; set; }

        /// <summary>
        /// کد اختصاصی شرکت
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// کد اختصاصی دسته محصول
        /// </summary>
        public Guid? CategoryId { get; set; }

        #endregion

        #region NavigationProperties


        #endregion
    }
   
}
