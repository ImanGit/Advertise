using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Public;

namespace Advertise.DomainClasses.Entities.Users
{
    /// <summary>
    ///     نشان دهنده کاربر
    /// </summary>
    public class UserProfile : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     کد کاربر
        /// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        ///     نام کاربر
        /// </summary>
        public virtual string FirstName { get; set; }

        /// <summary>
        ///     نام خانوادگی کاربر
        /// </summary>
        public virtual string LastName { get; set; }

        /// <summary>
        ///     نام نمایشی کاربر
        /// </summary>
        public virtual string DisplayName { get; set; }

        /// <summary>
        ///     کد ملی کاربر
        /// </summary>
        public virtual string NationalCode { get; set; }

        /// <summary>
        ///     تاریخ تولد کاربر
        /// </summary>
        public virtual DateTime? BirthDate { get; set; }

        /// <summary>
        ///     تاریخ ازدواج کاربر
        /// </summary>
        public virtual DateTime? MarriedDate { get; set; }

        /// <summary>
        ///     عکس یا لوگو کاربر
        /// </summary>
        public virtual string AvatarFileName { get; set; }

        /// <summary>
        ///     آیا کاربر فعال است؟
        /// </summary>
        public virtual bool IsActive { get; set; }

        /// <summary>
        ///     جنسیت کاربر
        /// </summary>
        public virtual GenderType? Gender { get; set; }

        /// <summary>
        /// </summary>
        public virtual string AboutMe { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کاربر
        /// </summary>
        public virtual User OwnedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid OwnedById { get; set; }

        /// <summary>
        ///     شهر محل زندگی کاربر
        /// </summary>
        public virtual Address Address { get; set; }

        /// <summary>
        ///     کلید خارجی شهر
        /// </summary>
        public virtual Guid AddressId { get; set; }

        #endregion
    }
}