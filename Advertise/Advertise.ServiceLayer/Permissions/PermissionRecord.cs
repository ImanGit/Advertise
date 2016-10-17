using System.Collections.Generic;

namespace Advertise.ServiceLayer.Security
{
    /// <summary>
    /// </summary>
    public class PermissionRecord
    {
        /// <summary>
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// </summary>
        public IEnumerable<PermissionModel> Permissions { get; set; }
    }
}