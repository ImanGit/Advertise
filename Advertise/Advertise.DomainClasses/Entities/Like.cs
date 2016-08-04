﻿using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Enum;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// 
    /// </summary>
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
        public LikeType Type { get; set; }

        /// <summary>
        /// تاریخ ثبت لایک
        /// </summary>
        public DateTime RegisterDate { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// کد اختصاصی کاربری که لایک انجام داده
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid CommentId { get; set; }

        /// <summary>
        /// کد اختصاصی کامنت
        /// </summary>
        public Comment Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// کد اختصاصی محصول
        /// </summary>
        public Product Product { get; set; }

        #endregion
    }
}
