using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common ;

namespace Advertise.DomainClasses.Entities
{
    public class Like : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Like()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// نوع لایک
        /// </summary>
        public int  LikeType { get; set; }

        /// <summary>
        /// تاریخ ثبت لایک
        /// </summary>
        public DateTime RegisterDate { get; set; }

        /// <summary>
        /// کد اختصاصی کاربری که لایک انجام داده
        /// </summary>
        public Guid  UserId { get; set; }

        #endregion

        #region NavigationProperties


        #endregion
    }

}
