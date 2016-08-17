using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Companies
{
    /// <summary>
    /// </summary>
    public class CompanyQuestionLike : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual bool IsLiked { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کمپانی
        /// </summary>
        public virtual CompanyQuestion Question { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid QuestionId { get; set; }

        /// <summary>
        ///     کد اختصاصی کاربر
        /// </summary>
        public virtual User Liker { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid LikerId { get; set; }

        #endregion
    }
}