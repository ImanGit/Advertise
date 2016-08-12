using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Enum;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده انواع لایک
    /// </summary>
    public class ProduectLike : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public ProduectLike()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// نوع لایک
        /// </summary>
        //public LikeType Type { get; set; }

        /// <summary>
        /// تاریخ ثبت لایک
        /// </summary>
        public DateTime RegisterDate { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid UserId { get; set; }

        /// <summary>
        /// کد اختصاصی کاربری که لایک انجام داده
        /// </summary>
        public virtual User User { get; set; }

       

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid ProductId { get; set; }

        /// <summary>
        /// کد اختصاصی محصول
        /// </summary>
        public virtual Product Product { get; set; }

        #endregion
    }
}
