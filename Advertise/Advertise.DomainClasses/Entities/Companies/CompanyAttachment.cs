using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Enum;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Companies
{
    /// <summary>
    /// </summary>
    public class CompanyAttachment : BaseEntity
    {
        #region Properties

        /// <summary>
        /// </summary>
        public virtual string FileName { get; set; }

        /// <summary>
        /// </summary>
        public virtual string FileSize { get; set; }

        /// <summary>
        /// </summary>
        public virtual string FileExtension { get; set; }

        /// <summary>
        /// </summary>
        public virtual long DownloadCount { get; set; }

        /// <summary>
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// </summary>
        public virtual AttachmentType Type { get; set; }

        /// <summary>
        /// </summary>
        public virtual bool IsApproved { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual User OwnedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid OwnedById { get; set; }

        /// <summary>
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CompanyId { get; set; }

        #endregion
    }
}