using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده پیام خصوصی
    /// </summary>
    public class Message : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Message()
        {
            Id = Guid.NewGuid();
            IsViewed = false;
        }

        #endregion

        #region Properties

        /// <summary>
        /// عنوان پیام خصوصی
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// متن پیام خصوصی
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// آیا پیام توسط کاربر خوانده شده؟
        /// </summary>
        public bool  IsViewed { get; set; }
      
        #endregion

        #region NavigationProperties

        /// <summary>
        /// کد اختصاصی کاربر فرستنده
        /// </summary>
        public virtual User FromUser  { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر گیرنده
        /// </summary>
        public virtual User ToUser { get; set; }

        /// <summary>
        /// کد پیام پاسخ داده شده
        /// </summary>
        public virtual Message  Reply  { get; set; }

        #endregion
    }
}
