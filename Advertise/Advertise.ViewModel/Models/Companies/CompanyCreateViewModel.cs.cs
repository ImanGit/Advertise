using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Advertise.ViewModel.Models.Common;
using System.Web.Mvc;

namespace Advertise.ViewModel.Models.Companies
{
  public   class CompanyCreateViewModel :BaseViewModel

    {

        [DisplayName("کد شناسه")]
        [Required(ErrorMessage = "لطفا کد شناسه را وارد کنید")]
        [StringLength(50, ErrorMessage = "کد شناسه باید کمتر از ۵۰ کاراکتر باشد")]
        public string Code { get; set; }

        [DisplayName ("نام شرکت")]
        [Required (ErrorMessage= " نام شرکت الزامی است")]
        [StringLength( 100,ErrorMessage ="نام شرکت/واحد خدماتی باید کمتر از 100 کاراکتر باشد")]
        public string BrandName { get; set; }

        [DisplayName ("توضیحات ")]
        public string Description { get; set; }

        [DisplayName ("مسیر لوگو")]
        public string LogoFileName { get; set; }

        [DisplayName ("مسیر بک گراند شرکت")]
        public string BackgroundFileName { get; set; }

        [DisplayName ("شماره ثابت")]
      //  [RegularExpression("[^0-9]", ErrorMessage = "فقط عدد وارد شود")]
        public  string PhoneNumber { get; set; }

        [DisplayName ("شماره همراه")]
        [Required (ErrorMessage ="وارد کردن شماره همراه الزامی است")]
        [StringLength( 11,ErrorMessage ="شماره همراه نباید بیش از 11 عدد باشد")]
       // [RegularExpression("[^0-9]", ErrorMessage = "فقط عدد وارد شود")]
        public  string MobileNumber { get; set; }

        [DisplayName ("آدرس ایمیل")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "آدرس ایمیل اشتباه است")]
        public  string Email { get; set; }

        [DisplayName ("آدرس وب سایت")]
        public  string WebSite { get; set; }

       // [RegularExpression("[^0-9]", ErrorMessage = "فقط عدد وارد شود")]
        [DisplayName ("تعداد افراد استخدامی")]
        public  long EmployeeCount { get; set; }

        [DisplayName ("سال تاسیس")]
        public DateTime EstablishedOn { get; set; }

        [DisplayName("بررسی")]
        [AllowHtml]
        public string Body { get; set; }


    }
}
