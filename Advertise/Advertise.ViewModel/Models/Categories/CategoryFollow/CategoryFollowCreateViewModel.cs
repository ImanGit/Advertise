
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel ;
using Advertise.ViewModel.Models.Common;

namespace Advertise.ViewModel.Models.Categories.CategoryFollow
{
     public  class CategoryFollowCreateViewModel:BaseViewModel 
    {
        //با توجه به اینکه این گزینه نیازی به نمایش جهت ایجاد ندارد خط زیر هم بلااستفاده است
        //[DisplayName("فالو")]
        public bool  IsFollow { get; set; }

    }
}
