using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Public
{
    /// <summary>
    /// </summary>
    public class Address : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual string Gps { get; set; }

        /// <summary>
        /// </summary>
        public virtual string Street { get; set; }

        /// <summary>
        /// </summary>
        public virtual string Extra { get; set; }

        /// <summary>
        ///     کد پستی شرکت
        /// </summary>
        public virtual string PostalCode { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی آدرس
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CityId { get; set; }


        /// <summary>
        ///     کد اختصاصی کاربر
        /// </summary>
        public virtual City User { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid UserId { get; set; }

        #endregion
    }
}