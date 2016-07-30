using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده کاربر
    /// </summary>
    public class User : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
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
        /// کد کاربر
        /// </summary>
        public Int32 Code { get; set; }

        /// <summary>
        /// نام کاربر
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// نام خانوادگی کاربر
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// نام نمایشی کاربر
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// کد ملی کاربر
        /// </summary>
        public string NationalCode { get; set; }

        /// <summary>
        /// تاریخ تولد کاربر
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// تاریخ ازدواج کاربر
        /// </summary>
        public DateTime? MarriedDate { get; set; }

        /// <summary>
        /// موقعیت مکانی کاربر
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// عکس یا لوگو کاربر
        /// </summary>
        public string AvatarPath { get; set; }

        /// <summary>
        /// آیا کاربر حذف شده است؟
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// آیا کاربر فعال است؟
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// جنسیت کاربر
        /// </summary>
        public GenderType? Gender { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// شهر محل زندگی کاربر
        /// </summary>
        public virtual Place Places { get; set; }

        /// <summary>
        /// لیست محصولات کاربر
        /// </summary>
        public ICollection<Product> Products { get; set; }

        /// <summary>
        /// لیست نظرات کاربر
        /// </summary>
        public ICollection<Comment> Comments { get; set; }

        /// <summary>
        /// لیست شرکت های کاربر
        /// </summary>
        public ICollection<Company> Companies { get; set; }

        /// <summary>
        /// لیست حساب مالی کاربر
        /// </summary>
        public ICollection<Budget> Budgets { get; set; }

        /// <summary>
        /// لیست علاقه مندی های کاربر
        /// </summary>
        public ICollection<Follow> Follows { get; set; }

        /// <summary>
        /// لیست پسند های کاربر
        /// </summary>
        public ICollection<Like> Likes { get; set; }

        /// <summary>
        /// لیست پرداختی های کاربر
        /// </summary>
        public ICollection<Payment> Payments { get; set; }

        /// <summary>
        /// لیست پیام های کاربر
        /// </summary>
        public ICollection<Message> Messages { get; set; }

        /// <summary>
        /// لیست نوتیفیکیشن های کاربر
        /// </summary>
        public ICollection<Notification> Notifications { get; set; }

        /// <summary>
        /// لیست سوال های کاربر
        /// </summary>
        public ICollection<QuestionAnswer> QuestionAnswers { get; set; }

        /// <summary>
        /// لیست اکانت کاربر
        /// </summary>
        public ICollection<Account> Accounts { get; set; }

        /// <summary>
        /// لیست پیام های عمومی کاربر
        /// </summary>
        public ICollection<Notice> Notices { get; set; }

        /// <summary>
        /// لیست لاگ های کاربر
        /// </summary>
        public ICollection<Log> Logs { get; set; }

        /// <summary>
        /// لیست تنظیمات کاربر
        /// </summary>
        public ICollection<Setting> Settings { get; set; }

        #endregion
    }
}