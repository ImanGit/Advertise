using System;

namespace Advertise.DomainClasses.Entities.Common
{
    /// <summary>
    /// نشان دهنده موجودیت پایه
    /// </summary>
    public abstract class BaseEntity : Entity
    {
        #region Properties

        /// <summary>
        /// شناسه یکتای موجودیت
        /// </summary>
        public virtual Guid Id { get; set; }

        #endregion
    }
}
