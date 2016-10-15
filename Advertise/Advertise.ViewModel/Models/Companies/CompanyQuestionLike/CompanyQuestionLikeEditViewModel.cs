using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ViewModel.Models.Companies.CompanyQuestionLike
{
   public  class CompanyQuestionLikeEditViewModel : BaseViewModel
    {
        // [DisplayName("کد شناسه")]
        public Guid Id { get; set; }
        public bool  IsLiked { get; set; }

    }
}
