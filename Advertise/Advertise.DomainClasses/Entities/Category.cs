using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common ;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده دسته بندی محصولات
    /// </summary>
    public class Category : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Category()
        {
            Id = Guid.NewGuid();
           
        }

        #endregion

        #region Properties

        /// <summary>
        /// کد دسته بندی
        /// </summary>
        public Int32 Code { get; set; }

        /// <summary>
        /// عنوان دسته بندی
        /// </summary>
        public string  Title { get; set; }

        /// <summary>
        /// توضیحات دسته بندی
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// پدر دسته بندی
        /// </summary>
        public Guid  ParentId { get; set; }

        #endregion

        #region NavigationProperties


        #endregion
    }
}
