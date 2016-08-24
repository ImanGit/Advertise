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

        /// <summary>
        /// </summary>
        public virtual bool IsDisLiked { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کاربر
        /// </summary>
        public virtual User LikedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid LikedById { get; set; }

        /// <summary>
        ///     کد اختصاصی کمپانی
        /// </summary>
        public virtual CompanyQuestion Question { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid QuestionId { get; set; }

        #endregion
    }
}