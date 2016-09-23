using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System .ComponentModel .DataAnnotations ;
using System.ComponentModel;
namespace Advertise.ViewModel.Models.Companies
{
  public   class CompanyDetailsViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("کد شناسه")]
        public string Code { get; set; }

        [DisplayName("نام شرکت")]
        [Required(ErrorMessage = " نام شرکت الزامی است")]
        [StringLength(100, ErrorMessage = "نام شرکت/واحد خدماتی باید کمتر از 100 کاراکتر باشد")]
        public string BrandName { get; set; }

        [DisplayName("توضیحات ")]
        public string Description { get; set; }

        [DisplayName("مسیر لوگو")]
        public string LogoFileName { get; set; }

        [DisplayName("مسیر بک گراند شرکت")]
        public string BackgroundFileName { get; set; }

        [DisplayName("شماره ثابت")]
        public string PhoneNumber { get; set; }

        [DisplayName("شماره همراه")]
        [Required(ErrorMessage = "وارد کردن شماره همراه الزامی است")]
        [StringLength(11, ErrorMessage = "شماره همراه نباید بیش از 11 عدد باشد")]
        public string MobileNumber { get; set; }

        [DisplayName("آدرس ایمیل")]
        public string Email { get; set; }

        [DisplayName("آدرس وب سایت")]
        public string WebSite { get; set; }

        [DisplayName("تعداد افراد استخدامی")]
        public long EmployeeCount { get; set; }

        [DisplayName("سال تاسیس")]
        public DateTime EstablishedOn { get; set; }

    }
}
