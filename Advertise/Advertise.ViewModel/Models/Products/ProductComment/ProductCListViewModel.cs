using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Enum ;
namespace Advertise.ViewModel.Models.Products.ProductComment
{
 public    class ProductCListViewModel : BaseViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("متن کامنت")]
        [Required(ErrorMessage = "لطفا متن کامنت را وارد کنید")]
        [StringLength(1000, ErrorMessage = "متن کامنت باید کمتر از 1000 کاراکتر باشد")]
        public string Body { get; set; }

        public bool IsApproved { get; set; }

        public CommentStatus Status { get; set; }
    }
}
