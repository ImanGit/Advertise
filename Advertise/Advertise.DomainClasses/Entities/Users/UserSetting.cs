using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Enum;

namespace Advertise.DomainClasses.Entities.Users
{
    /// <summary>
    /// </summary>
    public class UserSetting : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     زبان انتخابی کاربر
        /// </summary>
        public LanguageType Language { get; set; }

        /// <summary>
        ///     تم انتخابی کاربر
        /// </summary>
        public ThemeType Theme { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کاربر
        /// </summary>
        public virtual User OwnedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid OwnedById { get; set; }

        #endregion
    }
}