using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    ///     نشان دهنده پیام خصوصی
    /// </summary>
    public class Conversation : BaseEntity
    {
        #region Ctor

        #endregion

        #region Properties

        /// <summary>
        ///     عنوان پیام خصوصی
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        ///     متن پیام خصوصی
        /// </summary>
        public virtual string Body { get; set; }

        /// <summary>
        ///     آیا پیام توسط کاربر خوانده شده؟
        /// </summary>
        public virtual bool IsRead { get; set; }

        /// <summary>
        /// </summary>
        public virtual bool IsDeletedBySender { get; set; }

        /// <summary>
        /// </summary>
        public virtual bool IsDeletedByReceiver { get; set; }

        /// <summary>
        /// </summary>
        public virtual DateTime SentOn { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کاربر فرستنده
        /// </summary>
        public virtual User SendedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid SendedById { get; set; }

        /// <summary>
        ///     کد اختصاصی کاربر گیرنده
        /// </summary>
        public virtual User ReceivedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ReceivedById { get; set; }

        /// <summary>
        ///     کد پیام پاسخ داده شده
        /// </summary>
        public virtual Conversation Reply { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ReplyId { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<Conversation> Conversations { get; set; }

        #endregion
    }
}