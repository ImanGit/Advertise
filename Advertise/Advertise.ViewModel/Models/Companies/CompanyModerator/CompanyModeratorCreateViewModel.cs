using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ViewModel.Models.Companies.CompanyModerator
{
  public   class CompanyModeratorCreateViewModel : BaseViewModel

    {

        [DisplayName("فعال بودن کاربر")]
        public bool  IsActive { get; set; }
    }
}
