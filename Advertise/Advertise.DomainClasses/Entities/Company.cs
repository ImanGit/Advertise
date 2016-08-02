using System;
using Advertise.DomainClasses.Entities.Common ;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده کمپانی،شرکت یا واحد تولیدی و خدماتی
    /// </summary>
    public class Company : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Company()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// کد کمپانی
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// نام شرکت
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// توضیحات مربوط به شرکت
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// برند؟
        /// </summary>
        public string BrandFileName { get; set; }

        /// <summary>
        /// تاریخچه شرکت
        /// </summary>
        public string BackgroundFileName { get; set; }

        /// <summary>
        /// تعداد دیده شده شرکت
        /// </summary>
        public Int32? VisitedCount { get; set; }

        /// <summary>
        /// کد پستی شرکت
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// آدرس شرکت
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// شماره تلفن(های) شرکت
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// شماره همراه
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// آدرس ایمیل شرکت
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// آدرس وب سایت شرکت
        /// </summary>
        public string WebSite { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// کد کاربری
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// کد اختصاصی آدرس
        /// </summary>
        public virtual City City { get; set; }

        #endregion
    }
}
