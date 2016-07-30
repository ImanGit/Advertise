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
        public string Avatar { get; set; }

        /// <summary>
        /// آیا کاربر حذف شده است؟
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// آیا کاربر فعال است؟
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// موقعیت مکانی کاربر
        /// </summary>
        public Guid? PlaceId { get; set; }

        /// <summary>
        /// جنسیت کاربر
        /// </summary>
        public GenderType? Gender { get; set; }


        #endregion

        #region NavigationProperties

        /// <summary>
        /// لیست محصولات کاربر
        /// </summary>
        public ICollection<Product> Products { get; set; }

        public  ICollection<Comment> Comments { get; set; }
        //public ICollection<Company> Companies { get; set; }

        #endregion
    }
}
