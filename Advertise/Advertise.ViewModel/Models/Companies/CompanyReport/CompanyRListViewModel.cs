using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ViewModel.Models.Companies.CompanyReport
{
  public   class CompanyRListViewModel : BaseViewModel
    {
        public Guid Id { get; set; }
        public DataType Type { get; set; }
        public string Reason { get; set; }
        public bool IsRead { get; set; }

    }
}