using Advertise.ViewModel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ViewModel.Models.Companies.CompanySocial
{
    public class CompanySocialEditViewModel : BaseViewModel

    {

        public Guid Id { get; set; }
        [DisplayName("آدرس تویتر")]
        // [Required(ErrorMessage = "لطفا متن بررسی را وارد کنید")]
        //[StringLength(50, ErrorMessage = "کد شناسه باید کمتر از ۵۰ کاراکتر باشد")]
        public string TwitterLink { get; set; }

        [DisplayName("آدرس فیس بوک")]
        public string FacebookLink { get; set; }

        [DisplayName("آدرس گوگل پلاس")]
        public string GooglePlusLink { get; set; }

        [DisplayName("آدرس یوتیوب")]
        public string YoutubeLink { get; set; }

    }
}
