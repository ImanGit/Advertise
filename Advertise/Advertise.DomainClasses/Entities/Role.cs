using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Role : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Role()
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

        #endregion

        #region NavigationProperties

        /// <summary>
        /// توضیحات دسته بندی
        /// </summary>
        public virtual Action Action { get; set; }

        #endregion
    }
}
