using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده آدرس
    /// </summary>
    public class City : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public City()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// استان
        /// </summary>
        public bool IsState { get; set; }

        /// <summary>
        /// شهرستان
        /// </summary>
        public string CityName { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public Guid ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public City Parent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<City> Cities { get; set; }

        #endregion
    }
}
