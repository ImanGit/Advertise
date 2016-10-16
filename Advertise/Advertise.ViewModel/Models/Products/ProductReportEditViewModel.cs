using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Enum;
using System.ComponentModel;
using Advertise.ViewModel.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace Advertise.ViewModel.Models.Products
{
 public    class ProductReportEditViewModel : BaseViewModel
    {

        public Guid Id { get; set; }
        [DisplayName("نوع گزارش")]
        //[Required(ErrorMessage = "لطفا کد شناسه را وارد کنید")]
        //[StringLength(50, ErrorMessage = "کد شناسه باید کمتر از ۵۰ کاراکتر باشد")]
        public ReportType Type { get; set; }

        [DisplayName("متن گزارش")]
        [Required(ErrorMessage = "لطفا متن گزارش را وارد کنید")]
        //[StringLength(50, ErrorMessage = "کد شناسه باید کمتر از ۵۰ کاراکتر باشد")]
        public string Reason { get; set; }

        public bool IsRead { get; set; }

    }
}