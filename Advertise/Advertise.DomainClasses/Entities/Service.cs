using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common ;
namespace Advertise.DomainClasses.Entities
{
    public class Service : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Service()
        {
            Id = Guid.NewGuid();

        }

        #endregion

        #region Properties

        /// <summary>
        /// کد سرویس
        /// </summary>
        public Int32 Code { get; set; }

        /// <summary>
        /// عنوان سریس
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// متن سرویس
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// مدت سرویس(یکماهه،دو ماهه و...)
        /// </summary>
        public Guid Duration { get; set; }

        /// <summary>
        /// قیمت سرویس
        /// </summary>
        public Int32 Cost { get; set; }

        /// <summary>
        /// آیا سرویس فعال است؟
        /// </summary>
        public string IsEnabled { get; set; }

        /// <summary>
        /// تاریخ شروع سرویس
        /// </summary>
        public string FromDate { get; set; }

        /// <summary>
        /// تاریخ پایان سرویس
        /// </summary>
        public Guid ToDate { get; set; }

        #endregion

        #region NavigationProperties


        #endregion
    }
}
