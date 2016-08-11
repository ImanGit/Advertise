using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Image : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Image()
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
        public virtual Guid ProductId { get; set; }

        /// <summary>
        /// کداختصاصی محصول
        /// </summary>
        public virtual Product Product { get; set; }

        #endregion
    }
}
