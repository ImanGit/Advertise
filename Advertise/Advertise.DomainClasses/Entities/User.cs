using System;
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
            IsActive = false;
            IsAnonymous = true;
            IsBanned = false;
            IsEmailConfirmed = false;
            IsLockedOut = false;
            IsVerified = false;
            IsMobileConfirmed = false;
            FailedPasswordAttemptCount = 0;
            CreateDate = DateTime.Now;
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
        public string MobileNumber { get; set; }

        /// <summary>
        /// پسورد کاربر
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// تاریخ ثبت نام کاربر
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// نام کاربری ورود به برنامه
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// آخرین زمان ورود به سایت
        /// </summary>
        public DateTime LastLoginDate { get; set; }

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

        /// <summary>
        /// آیا کاربر مهمان است؟
        /// </summary>
        public bool IsAnonymous { get; set; }

        /// <summary>
        /// توکن تائید فعال سازی ایمیل
        /// </summary>
        public string EmailConfirmationToken { get; set; }

        /// <summary>
        /// توکن تائید فغال سازی موبایل
        /// </summary>
        public string MobileConfirmationToken { get; set; }

        /// <summary>
        /// آخرین زمان تغییر پسورد
        /// </summary>
        public DateTime LastPasswordChangedDate { get; set; }

        /// <summary>
        /// تعداد دفعاتی که پسورد اشتباه زده است 
        /// </summary>
        public int FailedPasswordAttemptCount { get; set; }

        /// <summary>
        ///بیش از تعداد تعیین شده بود،مقدار ترو میگیرد و کاربر نمیتواند تا زمانی تعیین شده وارد سایت شود FailedPasswordAttemptCount اگر تعداد 
        /// </summary>
        public bool IsLockedOut { get; set; }

        /// <summary>
        /// آخرین باری که کاربر Lockout شده
        /// </summary>
        public DateTime LastLockoutDate { get; set; }

        /// <summary>
        /// آخرین فعالیتی که کاربر انجام داده
        /// </summary>
        public DateTime LastActivityDate { get; set; }

        /// <summary>
        /// آخرین زمانی که کاربر وارد سایت شده
        /// </summary>
        public DateTime LastloginDate { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public virtual  Guid RoleId { get; set; }

        /// <summary>
        /// کد اختصاصی نقش
        /// </summary>
        public virtual Role Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid UserId { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر
        /// </summary>
        public virtual User User { get; set; }

        #endregion
    }
}
