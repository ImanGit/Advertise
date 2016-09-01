﻿using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Advertise.DomainClasses.Entities.Users
{
    /// <summary>
    /// </summary>
    public class UserRole : IdentityUserRole<Guid>
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual byte[] RowVersion { get; set; }

        #endregion

        #region NavigationProperties

        #endregion
    }
}