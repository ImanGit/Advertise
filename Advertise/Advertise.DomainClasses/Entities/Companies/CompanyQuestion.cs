using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Companies
{
    /// <summary>
    ///     نشان دهنده پرسش و پاسخ بین کاربر و کمپانی
    /// </summary>
    public class CompanyQuestion : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     عنوان پرسش و پاسخ
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        ///     متن پرسش و پاسخ
        /// </summary>
        public virtual string Body { get; set; }

        /// <summary>
        ///     تائید شدن پرسش یا پاسخ توسط اپراتور
        /// </summary>
        public virtual bool IsApproved { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی پاسخ
        /// </summary>
        public virtual CompanyQuestion Reply { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ReplyId { get; set; }

        /// <summary>
        ///     کد اختصاصی کمپانی
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CompanyId { get; set; }

        /// <summary>
        ///     کد اختصاصی کاربر
        /// </summary>
        public virtual User Questioner { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid QuestionerId { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<CompanyQuestion> Questions { get; set; }

        #endregion
    }
}