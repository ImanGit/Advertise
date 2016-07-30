using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Int32 Code { get; set; }

        /// <summary>
        /// نام شرکت
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// توضیحات مربوط به شرکت
        /// </summary>
        public string  Description { get; set; }

        /// <summary>
        /// برند؟
        /// </summary>
        public string  Brand { get; set; }

        /// <summary>
        /// تاریخچه شرکت
        /// </summary>
        public string  Background { get; set; }

        /// <summary>
        /// تعداد دیده شده شرکت
        /// </summary>
        public Int32? VisitCount { get; set; }

        /// <summary>
        /// کد پستی شرکت
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// آدرس شرکت
        /// </summary>
        public string Location { get; set; }

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

        /// <summary>
        /// کد اختصاصی آدرس
        /// </summary>
        public Guid PlaceId { get; set; }

        /// <summary>
        /// کد کاربری
        /// </summary>
        public Guid UserId { get; set; }

        #endregion

        #region NavigationProperties


        #endregion
    }

}
