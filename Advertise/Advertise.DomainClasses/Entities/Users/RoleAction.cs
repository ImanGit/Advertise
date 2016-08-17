using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Users
{
    /// <summary>
    /// </summary>
    public class RoleAction : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     عنوان اکشن
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        ///     نام اکشن
        /// </summary>
        public virtual string ActionName { get; set; }

        /// <summary>
        ///     نام کنترلر
        /// </summary>
        public virtual string ControllerName { get; set; }

        /// <summary>
        ///     فعال یا غیر فعال بودن اکشن
        /// </summary>
        public virtual bool IsActive { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کلید خارجی
        /// </summary>
        public virtual Role Role { get; set; }

        /// <summary>
        ///     کد اختصاصی نقش
        /// </summary>
        public virtual Guid RoleId { get; set; }

        #endregion
    }
}