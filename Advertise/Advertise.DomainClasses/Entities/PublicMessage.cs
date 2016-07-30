using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common ;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده پیام های عمومی
    /// </summary>
    public class PublicMessage : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public PublicMessage()
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
        public DateTime RegisterDate { get; set; }

        /// <summary>
        /// کاربری که پیام عمومی را ثبت کرده
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// دیده شدن و نشدن پیام
        /// </summary>
        public bool  IsVisible { get; set; }
        #endregion

        #region NavigationProperties


        #endregion
    }
}
