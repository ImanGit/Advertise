using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Products
{
    /// <summary>
    ///     مشخصات عکس ها
    /// </summary>
    public class ProductImage : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     عنوان عکس
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        ///     نام فایل
        /// </summary>
        public virtual string FileName { get; set; }

        /// <summary>
        ///     سایز عکس
        /// </summary>
        public virtual string FileSize { get; set; }

        /// <summary>
        ///     حجم عکس
        /// </summary>
        public virtual string FileDimension { get; set; }

        /// <summary>
        ///     ترتیب عکس
        /// </summary>
        public virtual int Order { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کداختصاصی محصول
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ProductId { get; set; }

        #endregion
    }
}