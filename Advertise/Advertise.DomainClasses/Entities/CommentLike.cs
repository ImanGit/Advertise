using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// لایک کردن کامنت ها
    /// </summary>
  public   class CommentLike :BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public CommentLike()
        {
            Id = Guid.NewGuid();
           
        }

        #endregion

        #region Properties

        /// <summary>
        /// تاریخ ایجاد کامنت
        /// </summary>
        public DateTime CreateDate { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid UserId { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر فرستنده
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid CommentId { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر گیرنده
        /// </summary>
        public virtual Comment  Comment { get; set; }

        #endregion
    }
}
