using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ViewModel.Models.Companies.CompanyReview
{
    public class CompanyReviewDetailViewModel : BaseViewModel

    {
        public Guid Id { get; set; }
        public string Body { get; set; }
        public bool Active { get; set; }
    }
}
