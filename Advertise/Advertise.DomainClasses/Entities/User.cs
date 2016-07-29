using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده کاربر
    /// </summary>
    public class User : BaseEntity
    {
        #region Ctor
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public User()
        {
            Id = Guid.NewGuid();
        }
        #endregion

        #region Properties
        /// <summary>
        /// نام کاربر
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// نام خانوادگی کاربر
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// جنسیت کاربر
        /// </summary>
        public GenderType Gender { get; set; }
        #endregion

        #region NavigationProperties
        /// <summary>
        /// لیست پست های کاربر
        /// </summary>
        public ICollection<Product> Products { get; set; }
        #endregion
    }
}
