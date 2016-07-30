using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده امنیت کاربر
    /// </summary>
    public class Account : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Account()
        {
            Id = Guid.NewGuid();

        }

        #endregion

        #region Properties

        /// <summary>
        /// ایمیل کاربر
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// موبایل کاربر
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// پسورد کاربر
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// تاریخ ثبت نام کاربر
        /// </summary>
        public DateTime  RegisterDate { get; set; }

        /// <summary>
        /// نام کاربری ورود به برنامه
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// آخرین زمان ورود به سایت
        /// </summary>
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// آیا کاربر بلاک شده؟
        /// </summary>
        public bool IsBanned { get; set; }

        /// <summary>
        /// آیا کاربر تائید شده است؟
        /// </summary>
        public bool IsVerified { get; set; }

        /// <summary>
        /// آیا کاربر فعال است؟
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// آیا ایمیل کاربر تائید شده است؟
        /// </summary>
        public bool IsEmailConfirmed { get; set; }

        /// <summary>
        /// آیا موبایل کاربر تائید شده است؟
        /// </summary>
        public bool IsMobileConfirmed { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// کد اختصاصی نقش
        /// </summary>
        public virtual Role Role { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر
        /// </summary>
        public virtual User User { get; set; }
        #endregion
    }
}
