using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Public
{
    /// <summary>
    ///     نشان دهنده آدرس
    /// </summary>
    public class City : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     استان
        /// </summary>
        public virtual bool IsState { get; set; }

        /// <summary>
        ///     شهرستان
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// </summary>
        public virtual bool IsActive { get; set; }

        /// <summary>
        /// </summary>
        public virtual string ParentPath { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual City Parent { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ParentId { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<City> Cities { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<Address> Addresses { get; set; }

        #endregion
    }
}