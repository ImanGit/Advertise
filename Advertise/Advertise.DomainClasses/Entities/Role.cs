using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
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
        public Int32 Code { get; set; }

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
