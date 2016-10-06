using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations ;
using System.ComponentModel;
using Advertise.ViewModel.Models.Common;

namespace Advertise.ViewModel.Models.Companies
{
  public   class CompanyDeleteViewModel :BaseViewModel 
    {
        public Guid Id { get; set; }
        /// <summary>
        ///     کد کمپانی
        /// </summary>
        public  string Code { get; set; }

        /// <summary>
        ///     نام شرکت
        /// </summary>
        public  string BrandName { get; set; }

        /// <summary>
        ///     توضیحات مربوط به شرکت
        /// </summary>
        public  string Description { get; set; }

        /// <summary>
        ///     لوگوی شرکت
        /// </summary>
        public  string LogoFileName { get; set; }

        /// <summary>
        ///     تاریخچه شرکت
        /// </summary>
        public  string BackgroundFileName { get; set; }

        /// <summary>
        ///     شماره تلفن(های) شرکت
        /// </summary>
        public  string PhoneNumber { get; set; }

        /// <summary>
        ///     شماره همراه
        /// </summary>
        public  string MobileNumber { get; set; }

        /// <summary>
        ///     آدرس ایمیل شرکت
        /// </summary>
        public  string Email { get; set; }

        /// <summary>
        ///     آدرس وب سایت شرکت
        /// </summary>
        public  string WebSite { get; set; }

        /// <summary>
        /// </summary>
        public  long EmployeeCount { get; set; }

        /// <summary>
        ///     سال تاسیس
        /// </summary>
        public  DateTime EstablishedOn { get; set; }

    }
}
