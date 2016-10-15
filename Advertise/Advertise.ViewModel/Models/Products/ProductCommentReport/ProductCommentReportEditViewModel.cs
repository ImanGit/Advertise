using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ViewModel.Models.Products.ProductCommentReport
{
 public    class ProductCommentReportEditViewModel : BaseViewModel
    {
        public Guid Id { get; set; }

        //  [DisplayName("نوع گزارش")]
        //[Required(ErrorMessage = "لطفا کد شناسه را وارد کنید")]
        //[StringLength(50, ErrorMessage = "کد شناسه باید کمتر از ۵۰ کاراکتر باشد")]
        // public DataType Type { get; set; }

        [DisplayName("متن گزارش")]
        [Required(ErrorMessage = "لطفا متن گزارش را وارد کنید")]
        //[StringLength(50, ErrorMessage = "کد شناسه باید کمتر از ۵۰ کاراکتر باشد")]
        public string Reason { get; set; }

        public bool IsRead { get; set; }

    }
}
