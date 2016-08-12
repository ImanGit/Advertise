using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Common;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    ///     نشان دهنده کاربر
    /// </summary>
    public class User : IdentityUser<Guid,UserLogin,UserRole,UserClaim>
    {
        #region Ctor

        /// <summary>
        ///     سازنده پیش فرض
        /// </summary>
        public User()
        {
            Id = Guid.NewGuid();
            IsActive = false;
            IsDeleted = false;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     کد کاربر
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        ///     نام کاربر
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///     نام خانوادگی کاربر
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///     نام نمایشی کاربر
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        ///     کد ملی کاربر
        /// </summary>
        public string NationalCode { get; set; }

        /// <summary>
        ///     تاریخ تولد کاربر
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        ///     تاریخ ازدواج کاربر
        /// </summary>
        public DateTime? MarriedDate { get; set; }

        /// <summary>
        ///     موقعیت مکانی کاربر
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        ///     عکس یا لوگو کاربر
        /// </summary>
        public string AvatarFileName { get; set; }

        /// <summary>
        ///     آیا کاربر حذف شده است؟
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        ///     آیا کاربر فعال است؟
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        ///     جنسیت کاربر
        /// </summary>
        public GenderType? Gender { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کلید خارجی شهر
        /// </summary>
        public virtual Guid CityId { get; set; }

        /// <summary>
        ///     شهر محل زندگی کاربر
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        ///     لیست محصولات کاربر
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }

        /// <summary>
        ///     لیست نظرات کاربر
        /// </summary>
        public virtual ICollection<Comment> Comments { get; set; }

        /// <summary>
        ///     لیست شرکت های کاربر
        /// </summary>
        public virtual ICollection<Company> Companies { get; set; }

        /// <summary>
        ///     لیست حساب مالی کاربر
        /// </summary>
        public virtual ICollection<Budget> Budgets { get; set; }

        /// <summary>
        ///     لیست علاقه مندی های کاربر
        /// </summary>
        public virtual ICollection<Follow> Follows { get; set; }

        /// <summary>
        ///     لیست پسند های کاربر
        /// </summary>
        public virtual ICollection<Like> Likes { get; set; }

        /// <summary>
        ///     لیست پرداختی های کاربر
        /// </summary>
        public virtual ICollection<Payment> Payments { get; set; }

        /// <summary>
        ///     لیست پیام های کاربر
        /// </summary>
        public virtual ICollection<Message> Messages { get; set; }

        /// <summary>
        ///     لیست نوتیفیکیشن های کاربر
        /// </summary>
        public virtual ICollection<Notification> Notifications { get; set; }

        /// <summary>
        ///     لیست سوال های کاربر
        /// </summary>
        public virtual ICollection<Question> Questions { get; set; }

        /// <summary>
        ///     لیست اکانت کاربر
        /// </summary>
        public virtual ICollection<Account> Accounts { get; set; }

        /// <summary>
        ///     لیست پیام های عمومی کاربر
        /// </summary>
        public virtual ICollection<Notice> Notices { get; set; }

        /// <summary>
        ///     لیست لاگ های کاربر
        /// </summary>
        public virtual ICollection<Log> Logs { get; set; }

        /// <summary>
        ///     لیست تنظیمات کاربر
        /// </summary>
        public virtual ICollection<Setting> Settings { get; set; }

        #endregion
    }
}