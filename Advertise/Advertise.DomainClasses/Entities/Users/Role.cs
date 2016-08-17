using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Advertise.DomainClasses.Entities.Users
{
    /// <summary>
    /// </summary>
    public class Role : IdentityRole<Guid, UserRole>
    {
        #region NavigationProperties

        /// <summary>
        ///     توضیحات دسته بندی
        /// </summary>
        public virtual ICollection<RoleAction> Actions { get; set; }

        #endregion

        #region Properties

        /// <summary>
        ///     کد دسته بندی
        /// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        /// </summary>
        public virtual byte[] RowVersion { get; set; }

        /// <summary>
        /// </summary>
        public virtual RoleType RoleType { get; set; }

        #endregion
    }
}