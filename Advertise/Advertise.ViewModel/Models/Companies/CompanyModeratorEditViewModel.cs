using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ViewModel.Models.Companies
{
 public    class CompanyModeratorEditViewModel : BaseViewModel

    {
        public Guid  Id { get; set; }
        [DisplayName("فعال بودن کاربر")]
        public bool IsActive { get; set; }
    }
}


