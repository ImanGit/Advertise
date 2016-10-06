using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ViewModel.Models.Companies.CompanyQuestion
{
public    class CompanyQDeleteViewModel : BaseViewModel
    {
        public Guid  Id { get; set; }

        [DisplayName("عنوان سوال")]
        [Required(ErrorMessage = "لطفا عنوان سوال را وارد کنید")]
        //[StringLength(50, ErrorMessage = "کد شناسه باید کمتر از ۵۰ کاراکتر باشد")]
        public string Title { get; set; }

        [DisplayName("متن سوال")]
        [Required(ErrorMessage = "لطفا متن سوال را وارد کنید")]
        //[StringLength(50, ErrorMessage = "کد شناسه باید کمتر از ۵۰ کاراکتر باشد")]
        public string Body { get; set; }

        public bool IsApproved { get; set; }

    }
}
