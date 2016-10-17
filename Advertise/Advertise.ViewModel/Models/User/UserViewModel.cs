using System;
using Advertise.ViewModel.Models.Common;

namespace Advertise.ViewModel.Models.Users
{
    /// <summary>
    /// </summary>
    public class UserViewModel : BaseViewModel
    {
        #region Properties

        /// <summary>
        ///     آی دی
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     نام کاربری
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///     قفل شده؟
        /// </summary>
        public bool IsBanned { get; set; }

        /// <summary>
        ///     اکانت سیستمی است؟
        /// </summary>
        public bool IsSystemAccount { get; set; }

        /// <summary>
        ///     نام /نام خانوادگی
        /// </summary>
        public string DisplayName { get; set; }

        #endregion
    }
}