using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Common;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Role : IdentityRole<Guid,UserRole>
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Role()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// کد دسته بندی
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// عنوان دسته بندی
        /// </summary>
        public string Title { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// توضیحات دسته بندی
        /// </summary>
        public virtual ICollection<Action> Actions { get; set; }

        #endregion
    }
}
