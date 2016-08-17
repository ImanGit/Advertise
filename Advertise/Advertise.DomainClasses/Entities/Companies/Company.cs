using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Companies
{
    /// <summary>
    ///     نشان دهنده کمپانی،شرکت یا واحد تولیدی و خدماتی
    /// </summary>
    public class Company : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     کد کمپانی
        /// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        ///     نام شرکت
        /// </summary>
        public virtual string BrandName { get; set; }

        /// <summary>
        ///     توضیحات مربوط به شرکت
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        ///     برند؟
        /// </summary>
        public virtual string LogoFileName { get; set; }

        /// <summary>
        ///     تاریخچه شرکت
        /// </summary>
        public virtual string BackgroundFileName { get; set; }

        /// <summary>
        ///     کد پستی شرکت
        /// </summary>
        public virtual string PostalCode { get; set; }

        /// <summary>
        ///     آدرس شرکت
        /// </summary>
        public virtual string Address { get; set; }

        /// <summary>
        ///     شماره تلفن(های) شرکت
        /// </summary>
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        ///     شماره همراه
        /// </summary>
        public virtual string MobileNumber { get; set; }

        /// <summary>
        ///     آدرس ایمیل شرکت
        /// </summary>
        public virtual string Email { get; set; }

        /// <summary>
        ///     آدرس وب سایت شرکت
        /// </summary>
        public virtual string WebSite { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد کاربری
        /// </summary>
        public virtual User Owner { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid OwnerId { get; set; }

        /// <summary>
        ///     کد اختصاصی آدرس
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CityId { get; set; }

        #endregion
    }
}