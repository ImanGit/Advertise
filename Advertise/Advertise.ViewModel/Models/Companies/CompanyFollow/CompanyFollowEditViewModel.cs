using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.ViewModel.Models.Common;

namespace Advertise.ViewModel.Models.Companies.CompanyFollow
{
   public  class CompanyFollowEditViewModel:BaseViewModel
    {
        public Guid Id { get; set; }
        public bool IsFollow { get; set; }

    }
}
