using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// مشخصات عکس ها
    /// </summary>
    public class ProductImage : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public ProductImage()
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
        public virtual Product  Product { get; set; }

        #endregion
    }
}

