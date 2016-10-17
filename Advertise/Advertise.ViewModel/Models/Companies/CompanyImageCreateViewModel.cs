using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ViewModel.Models.Companies
{
   public  class CompanyImageCreateViewModel : BaseViewModel

    {

       // [DisplayName("کد شناسه")]
       // [Required(ErrorMessage = "لطفا کد شناسه را وارد کنید")]
        //[StringLength(50, ErrorMessage = "کد شناسه باید کمتر از ۵۰ کاراکتر باشد")]
        public string Title { get; set; }

        // [DisplayName("کد شناسه")]
       // [Required(ErrorMessage = "لطفا کد شناسه را وارد کنید")]
        public string FileName { get; set; }

        public string FileSize { get; set; }

       // [DisplayName("کد شناسه")]
        public string FileDimension { get; set; }

        public int Order { get; set; }

     
    }
}
