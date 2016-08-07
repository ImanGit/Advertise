using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده مقادیر فیلدها
    /// </summary>
    public class Property : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Property()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public string Value { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid PropertyTemplateId { get; set; }

        /// <summary>
        ///
        /// </summary>
        public PropertyTemplate PropertyTemplate { get; set; }

        #endregion
    }
}
