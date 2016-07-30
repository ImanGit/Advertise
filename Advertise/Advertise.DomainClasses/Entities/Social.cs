using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities.Common ;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده شبکه های اجتماعی
    /// </summary>
    public class Social : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Social()
        {
            Id = Guid.NewGuid();

        }

        #endregion

        #region Properties

        /// <summary>
        /// اکانت تویتر شرکت
        /// </summary>
        public string Twitter { get; set; }

        /// <summary>
        /// اکانت فیس بوک شرکت
        /// </summary>
        public string Facebook { get; set; }

        /// <summary>
        /// اکانت گوگل پلاس شرکت
        /// </summary>
        public string GooglePlus { get; set; }

        /// <summary>
        /// اکانت آپارات شرکت
        /// </summary>
        public string Aparat { get; set; }

        /// <summary>
        /// کد اختصاصی شرکت
        /// </summary>
        public Guid CompanyId { get; set; }

        #endregion

        #region NavigationProperties


        #endregion
    }
}
