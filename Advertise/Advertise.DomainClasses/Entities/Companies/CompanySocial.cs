using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Companies
{
    /// <summary>
    ///     نشان دهنده شبکه های اجتماعی
    /// </summary>
    public class CompanySocial : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     اکانت تویتر شرکت
        /// </summary>
        public virtual string TwitterLink { get; set; }

        /// <summary>
        ///     اکانت فیس بوک شرکت
        /// </summary>
        public virtual string FacebookLink { get; set; }

        /// <summary>
        ///     اکانت گوگل پلاس شرکت
        /// </summary>
        public virtual string GooglePlusLink { get; set; }

        /// <summary>
        ///     اکانت یوتیوب شرکت
        /// </summary>
        public virtual string YoutubeLink { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی شرکت
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CompanyId { get; set; }

        #endregion
    }
}