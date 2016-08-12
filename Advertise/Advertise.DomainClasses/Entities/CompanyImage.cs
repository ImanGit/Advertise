using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// مشخصات عکس ها
    /// </summary>
    public class CompanyImage : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public CompanyImage()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// عنوان عکس
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// نام فایل
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// سایز عکس
        /// </summary>
        public string FileSize { get; set; }

        /// <summary>
        /// حجم عکس
        /// </summary>
        public string FileDimension { get; set; }

        /// <summary>
        /// ترتیب عکس
        /// </summary>
        public int Order { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid CompanyId { get; set; }

        /// <summary>
        /// کداختصاصی محصول
        /// </summary>
        public virtual Company  Company { get; set; }

        #endregion
    }
}
