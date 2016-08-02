﻿using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Enum;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده لاگ سیستم
    /// </summary>
    public class Log : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Log()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// متن لاگ
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// عمل لاگ(خطا یا Info)
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public LogLevelType LogLevel { get; set; }

        /// <summary>
        /// تاریخ ایجاد لاگ
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر
        /// </summary>
        public User User { get; set; }

        #endregion

        #region NavigationProperties


        #endregion
    }
}
