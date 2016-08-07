namespace Advertise.DomainClasses.Entities.Common
{
    /// <summary>
    /// نشان دهنده موجودیت
    /// </summary>
    public abstract class Entity
    {
        #region Properties

        /// <summary>
        /// تایم استمپ برای مباحث همزمانی
        /// </summary>
        public virtual byte[] RowVersion { get; set; }

        #endregion
    }
}
