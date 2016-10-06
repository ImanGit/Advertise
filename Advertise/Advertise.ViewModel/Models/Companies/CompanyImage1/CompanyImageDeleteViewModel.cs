using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ViewModel.Models.Companies.CompanyImage1
{
  public   class CompanyImageDeleteViewModel : BaseViewModel
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public string FileDimension { get; set; }
        public int Order { get; set; }

    }
}
