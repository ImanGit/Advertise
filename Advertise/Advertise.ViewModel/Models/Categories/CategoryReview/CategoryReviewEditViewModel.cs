using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ViewModel.Models.Categories.CategoryReview
{
public     class CategoryReviewEditViewModel : BaseViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("متن نقد و بررسی")]
        // [Required(ErrorMessage = "لطفا محتوای نقد و بررسی را وارد کنید")]
        public string Body { get; set; }

        [DisplayName("فعال")]
        public bool  IsActive { get; set; }
    }

 }
