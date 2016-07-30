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
    public class PrivateMessage : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public PrivateMessage()
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

        /// <summary>
        /// کد پیام پاسخ داده شده
        /// </summary>
        public Guid ReplyId { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر فرستنده
        /// </summary>
        public Guid FromUserId { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر گیرنده
        /// </summary>
        public Guid ToUserId { get; set; }

        #endregion

        #region NavigationProperties


        #endregion
    }
}
