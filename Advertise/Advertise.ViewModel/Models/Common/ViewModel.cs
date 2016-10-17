using System;
using System.ComponentModel;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.ViewModel.Models.Common
{
    /// <summary>
    /// </summary>
    public abstract class ViewModel
    {
        /// <summary>
        ///     نام کاربری ایجاد کننده رکورد
        /// </summary>
        [DisplayName("ایجاد کننده")]
        public string CreatorUserName { get; set; }

        /// <summary>
        ///     نام کاربری آخرین ویرایش کننده رکورد
        /// </summary>
        [DisplayName("آخرین ویرایش کننده")]
        public string LastModifierUserName { get; set; }

        /// <summary>
        ///     حذف شده است؟
        /// </summary>
        [DisplayName("حذف شده")]
        public bool IsDeleted { get; set; }

        /// <summary>
        ///     تاریخ درج
        /// </summary>
        [DisplayName("تاریخ درج")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        ///     آخرین تاریخ ویرایش
        /// </summary>
        [DisplayName("تاریخ آخرین ویرایش")]
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        ///     نوع اکشن انجام شده
        /// </summary>
        [DisplayName("نوع عملیات")]
        public AuditLogType Action { get; set; }

        /// <summary>
        /// gets or sets count of Modification Default is 1
        /// </summary>
        public int Version { get; set; }
    }
}