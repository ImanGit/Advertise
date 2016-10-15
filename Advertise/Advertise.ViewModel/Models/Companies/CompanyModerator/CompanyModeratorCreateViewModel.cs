using Advertise.ViewModel.Models.Common;
using System.ComponentModel;

namespace Advertise.ViewModel.Models.Companies.CompanyModerator
{
  public   class CompanyModeratorCreateViewModel : BaseViewModel

    {

        [DisplayName("فعال بودن کاربر")]
        public bool  IsActive { get; set; }
    }
}
