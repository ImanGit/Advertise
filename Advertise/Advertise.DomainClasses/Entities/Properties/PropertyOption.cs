using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Properties
{
    /// <summary>
    /// </summary>
    public class PropertyOption : BaseEntity
    {
        #region Properties

        /// <summary>
        /// عنوان گزینه‌ی مورد نظر
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// توضیح بیشتر برای گزینه‌ی مورد نظر
        /// </summary>
        public virtual string Description { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual Property Property { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid PropertyId { get; set; }

        #endregion
    }
}