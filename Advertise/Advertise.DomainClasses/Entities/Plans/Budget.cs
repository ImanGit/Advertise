using System;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Plans
{
    /// <summary>
    /// نشان دهنده بودجه حساب مالی کاربر
    /// </summary>
    public class Budget : BaseEntity
    {
        #region Properties

        /// <summary>
        /// بودجه باقی مانده حساب مالی کاربر
        /// </summary>
        public Int32 RemainValue { get; set; }

        /// <summary>
        /// افزایش و کاهش حساب مالی کاربر
        /// </summary>
        public Int32 IncDecValue { get; set; }

        /// <summary>
        /// کدرهگیری که بانک میدهد
        /// </summary>
        public string RefrenceCode { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid UserId { get; set; }

        /// <summary>
        /// کد اختصاصی کاربر
        /// </summary>
        public virtual User User { get; set; }

        #endregion
    }
}
