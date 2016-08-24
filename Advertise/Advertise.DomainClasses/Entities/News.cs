using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    ///     نشان دهنده پیام های عمومی
    /// </summary>
    public class News : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     عنوان پیام عمومی
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     متن پیام عمومی
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     دیده شدن و نشدن پیام
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// </summary>
        public DateTime? ExpireOn { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کاربری که پیام عمومی را ثبت کرده
        /// </summary>
        public virtual User OwnedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid OwnedById { get; set; }

        #endregion
    }
}