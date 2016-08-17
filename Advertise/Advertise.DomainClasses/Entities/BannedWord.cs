using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// </summary>
    public class BannedWord : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual string BadWord { get; set; }

        /// <summary>
        /// </summary>
        public virtual string GoodWord { get; set; }

        /// <summary>
        /// </summary>
        public virtual bool IsStopWord { get; set; }

        #endregion
    }
}