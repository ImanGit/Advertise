﻿using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Action : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Action()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// عنوان اکشن
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// نام اکشن
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// نام کنترلر
        /// </summary>
        public string ControllerName { get; set; }

        /// <summary>
        /// فعال یا غیر فعال بودن اکشن
        /// </summary>
        public bool IsEnable { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// کد اختصاصی نقش
        /// </summary>
        public virtual Guid RoleId { get; set; }

        /// <summary>
        /// کلید خارجی
        /// </summary>
        public virtual Role Role { get; set; }

        #endregion
    }
}
