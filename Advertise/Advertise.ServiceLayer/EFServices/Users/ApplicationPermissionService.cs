using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Advertise.ServiceLayer.Contracts.Users;
using Advertise.ServiceLayer.Security;

namespace Advertise.ServiceLayer.EFServices.Users
{
    /// <summary>
    /// </summary>
    public class ApplicationPermissionService : IApplicationPermissionService
    {
        #region Ctor

        #endregion

        #region GetPermissionsAsXml

        /// <summary>
        /// </summary>
        /// <param name="permissionNames"></param>
        /// <returns></returns>
        public XElement GetPermissionsAsXml(params string[] permissionNames)
        {
            var permissionsAsXml = new XElement(PermissionsElement);
            foreach (var permissionName in permissionNames)
            {
                permissionsAsXml.Add(new XElement(PermissionElement, permissionName));
            }
            return permissionsAsXml;
        }

        #endregion

        #region GetUserPermissionsAsList

        /// <summary>
        /// </summary>
        /// <param name="permissionsAsXml"></param>
        /// <returns></returns>
        public IList<string> GetUserPermissionsAsList(XElement permissionsAsXml)
        {
            return permissionsAsXml.Elements(PermissionElement).Select(a => a.Value).ToList();
        }

        #endregion

        #region GetUserPermissionsAsList

        /// <summary>
        /// </summary>
        /// <param name="permissionsAsXmls"></param>
        /// <returns></returns>
        public IList<string> GetUserPermissionsAsList(IList<XElement> permissionsAsXmls)
        {
            var permissions = new List<string>();
            foreach (var permissionsAsXml in permissionsAsXmls.Where(permissionsAsXml => permissionsAsXml != null))
            {
                permissions.AddRange(permissionsAsXml.Elements(PermissionElement).Select(a => a.Value).ToList());
            }
            return permissions;
        }

        #endregion

        #region GetDescriptions

        /// <summary>
        /// </summary>
        /// <param name="permissionsAsXml"></param>
        /// <returns></returns>
        public IEnumerable<string> GetDescriptions(XElement permissionsAsXml)
        {
            var permissions = AssignableToRolePermissions.Permissions;
            return permissions.Where(
                r =>
                    GetUserPermissionsAsList(permissionsAsXml)
                        .ToArray()
                        .Any(p => p == r.Name)).Select(r => r.Description);
        }

        #endregion

        #region Fields

        private const string PermissionsElement = "Permissions";
        private const string PermissionElement = "Permission";

        #endregion
    }
}