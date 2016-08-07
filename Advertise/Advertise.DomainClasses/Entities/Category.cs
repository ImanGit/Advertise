using System;
using System.Collections.Generic;
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
        public string Code { get; set; }

        /// <summary>
        /// عنوان دسته بندی
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// توضیحات دسته بندی
        /// </summary>
        public string Description { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public Guid ParentId { get; set; }

        /// <summary>
        /// والد دسته بندی
        /// </summary>
        public Category Parent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<Category> Categories { get; set; }

        #endregion
    }
}
