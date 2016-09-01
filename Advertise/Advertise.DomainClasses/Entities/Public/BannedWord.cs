using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Public
{
    /// <summary>
    /// </summary>
    public class BannedWord : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     کلمه مورد نظر که قرار است Ban شود
        /// </summary>
        public virtual string BadWord { get; set; }

        /// <summary>
        ///     کلمه جایگزین
        /// </summary>
        public virtual string GoodWord { get; set; }

        /// <summary>
        ///     اگر لازم نیست جایگزینی برای کلمه استفاده شود و فقط لازم است حذف گردد، مقدار این خصوصیت true خواهد بود
        /// </summary>
        public virtual bool IsStopWord { get; set; }

        #endregion

        #region NavigationProperties

        #endregion
    }
}