using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده پرسش و پاسخ بین کاربر و کمپانی
    /// </summary>
    public class QuestionAnswer : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public QuestionAnswer()
        {
            Id = Guid.NewGuid();
            IsAllowed = false;

        }

        #endregion

        #region Properties

        /// <summary>
        /// عنوان پرسش و پاسخ
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// متن پرسش و پاسخ
        /// </summary>
        public string  Content { get; set; }
        /// <summary>
        /// تاریخ ایجاد پرسش و پاسخ
        /// </summary>
        public DateTime RegisterDate { get; set; }

        /// <summary>
        /// تعداد لایک پرسش و پاسخ
        /// </summary>
        public Int32  LikeCount { get; set; }

        /// <summary>
        /// تائید شدن پرسش یا پاسخ توسط اپراتور
        /// </summary>
        public bool  IsAllowed { get; set; }

        /// <summary>
        /// کد اختصاصی پاسخ
        /// </summary>
        public Guid ReplyId { get; set; }

        /// <summary>
        /// کد اختصاصی کمپانی
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر
        /// </summary>
        public Guid UserId { get; set; }


        #endregion

        #region NavigationProperties


        #endregion
    }
}
