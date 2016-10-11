using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.ViewModel.Models.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Advertise.ViewModel.Models.Companies.CompanyQuestionLike
{
     public class CompanyQlCreateViewModel:BaseViewModel 
    {
       // [DisplayName("کد شناسه")]
        public bool IsLiked { get; set; }

    }
}
