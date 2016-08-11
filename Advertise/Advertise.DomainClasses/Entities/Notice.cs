using System;
using Advertise.DomainClasses.Entities.Common ;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده پیام های عمومی
    /// </summary>
    public class Notice : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Notice()
        {
            Id = Guid.NewGuid();
            IsVisible = true;
        }

        #endregion

        #region Properties

        /// <summary>
        /// عنوان پیام عمومی
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// متن پیام عمومی
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// تاریخ ایجاد پیام عمومی
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// دیده شدن و نشدن پیام
        /// </summary>
        public bool IsVisible { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid UserId { get; set; }

        /// <summary>
        /// کاربری که پیام عمومی را ثبت کرده
        /// </summary>
        public virtual User User { get; set; }

        #endregion
    }
}
