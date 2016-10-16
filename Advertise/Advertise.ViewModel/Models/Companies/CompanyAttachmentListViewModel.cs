using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.ViewModel.Models.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Advertise.DomainClasses.Entities.Enum;

namespace Advertise.ViewModel.Models.Companies
{
   public  class CompanyAttachmentListViewModel:BaseViewModel 
    {
        public Guid Id { get; set; }
        [DisplayName("مسیر فایل")]
        [Required(ErrorMessage = "لطفا مسیر فایل را وارد کنید")]
        // [StringLength(50, ErrorMessage = "کد شناسه باید کمتر از ۵۰ کاراکتر باشد")]
        public string FileName { get; set; }

        public string FileSize { get; set; }

        public string FileExtension { get; set; }

        public long DownloadCount { get; set; }
        
        public string Title { get; set; }

        public string Description { get; set; }

        public AttachmentType Type { get; set; }

        public bool IsApproved { get; set; }
    }
}
