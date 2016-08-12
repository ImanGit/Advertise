using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده شبکه های اجتماعی
    /// </summary>
    public class UserSocial : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public UserSocial()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// اکانت تویتر شرکت
        /// </summary>
        public string TwitterLink { get; set; }

        /// <summary>
        /// اکانت فیس بوک شرکت
        /// </summary>
        public string FacebookLink { get; set; }

        /// <summary>
        /// اکانت گوگل پلاس شرکت
        /// </summary>
        public string GooglePlusLink { get; set; }

        /// <summary>
        /// اکانت آپارات شرکت
        /// </summary>
        public string AparatLink { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid UserId { get; set; }

        /// <summary>
        /// کد اختصاصی شرکت
        /// </summary>
        public virtual User  User { get; set; }

        #endregion
    }
}

