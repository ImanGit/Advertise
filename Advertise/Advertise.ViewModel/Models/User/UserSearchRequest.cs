using System;
using System.ComponentModel;
using Advertise.ViewModel.Models.Common;

namespace Advertise.ViewModel.Models.Users
{
    /// <summary>
    /// </summary>
    public class UserSearchRequest : BaseSearchRequest
    {
        /// <summary>
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///     گروه  کاربری
        /// </summary>
        [DisplayName("گروه کاربری")]
        public Guid? RoleId { get; set; }
    }
}