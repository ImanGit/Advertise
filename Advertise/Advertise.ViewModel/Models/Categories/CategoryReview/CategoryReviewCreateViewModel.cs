using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.ViewModel.Models.Common;


namespace Advertise.ViewModel.Models.Categories.CategoryReview
{
  public   class CategoryReviewCreateViewModel:BaseViewModel 
    {
        [DisplayName("متن نقد و بررسی")]
        [Required (ErrorMessage ="لطفا محتوای نقد و بررسی را وارد کنید")]
        public string Body { get; set; }

        [DisplayName ("فعال")]
        public bool  IsActive { get; set; }
    }
}
