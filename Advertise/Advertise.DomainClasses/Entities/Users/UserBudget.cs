using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities.Users
{
    /// <summary>
    ///     نشان دهنده بودجه حساب مالی کاربر
    /// </summary>
    public class UserBudget : BaseEntity
    {
        #region Properties

        /// <summary>
        ///     بودجه باقی مانده حساب مالی کاربر
        /// </summary>
        public int RemainRialValue { get; set; }

        /// <summary>
        ///     افزایش و کاهش حساب مالی کاربر
        /// </summary>
        public int IncDecValue { get; set; }

        /// <summary>
        /// </summary>
        public string Description { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کد اختصاصی کاربر
        /// </summary>
        public virtual User OwnedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid OwnedById { get; set; }

        #endregion
    }
}