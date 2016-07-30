using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
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
        /// نام عکس
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// نام فایل
        /// </summary>
        public string  FileName { get; set; }

        /// <summary>
        /// سایز عکس
        /// </summary>
        public string  Size { get; set; }

        /// <summary>
        /// حجم عکس
        /// </summary>
        public string  Dimension { get; set; }

        /// <summary>
        /// ترتیب عکس
        /// </summary>
        public int  Order { get; set; }

        /// <summary>
        /// کداختصاصی محصول
        /// </summary>
        public Guid ProductId { get; set; }

        #endregion

        #region NavigationProperties


        #endregion
    }


}
