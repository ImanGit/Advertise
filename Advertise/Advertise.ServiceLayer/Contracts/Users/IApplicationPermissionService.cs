using System.Collections.Generic;
using System.Xml.Linq;

namespace Advertise.ServiceLayer.Contracts.Users
{
    /// <summary>
    /// </summary>
    public interface IApplicationPermissionService
    {
        /// <summary>
        /// </summary>
        /// <param name="permissionNames"></param>
        /// <returns></returns>
        XElement GetPermissionsAsXml(params string[] permissionNames);

        /// <summary>
        /// </summary>
        /// <param name="permissionsAsXml"></param>
        /// <returns></returns>
        IList<string> GetUserPermissionsAsList(XElement permissionsAsXml);

        /// <summary>
        /// </summary>
        /// <param name="permissionsAsXmls"></param>
        /// <returns></returns>
        IList<string> GetUserPermissionsAsList(IList<XElement> permissionsAsXmls);

        /// <summary>
        /// </summary>
        /// <param name="permissionsAsXml"></param>
        /// <returns></returns>
        IEnumerable<string> GetDescriptions(XElement permissionsAsXml);
    }
}