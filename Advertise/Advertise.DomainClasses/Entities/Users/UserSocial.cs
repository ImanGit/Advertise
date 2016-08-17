using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Users
{
    /// <summary>
    ///     نشان دهنده شبکه های اجتماعی
    /// </summary>
    public class UserSocial : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     اکانت تویتر شرکت
        /// </summary>
        public string TwitterLink { get; set; }

        /// <summary>
        ///     اکانت فیس بوک شرکت
        /// </summary>
        public string FacebookLink { get; set; }

        /// <summary>
        ///     اکانت گوگل پلاس شرکت
        /// </summary>
        public string GooglePlusLink { get; set; }

        /// <summary>
        ///     اکانت یوتیوب شرکت
        /// </summary>
        public string YoutubeLink { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی شرکت
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid UserId { get; set; }

        #endregion
    }
}