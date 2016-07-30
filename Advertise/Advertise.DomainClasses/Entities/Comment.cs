using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده سیستم کامنت گذاری
    /// </summary>
    public  class Comment :BaseEntity 
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Comment()
        {
            Id = Guid.NewGuid();
            IsAccepted = false;
        }

        #endregion

        #region Properties

        /// <summary>
        /// متن کامنت
        /// </summary>
        public string  Content { get; set; }

        /// <summary>
        /// تاریخ ایجاد کامنت
        /// </summary>
        public DateTime RegisterDate { get; set; }

        /// <summary>
        /// تعداد لایکهای کامنت
        /// </summary>
        public Int32? LikeCount { get; set; }

        /// <summary>
        /// آیا کامنت از سوی اپراتور پذیرفته شده است؟
        /// </summary>
        public bool  IsAccepted { get; set; }

        /// <summary>
        /// کاربری (اپراتور)که کامنت را تائید کرده است
        /// </summary>
        public Guid?  UserIdIsAccept { get; set; }

        #endregion

        #region NavigationProperties
        /// <summary>
        /// کاربری که کامنت گذاشته 
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// کداختصاصی محصول
        /// </summary>
        public virtual Product Product  { get; set; }

        #endregion
    }
}
