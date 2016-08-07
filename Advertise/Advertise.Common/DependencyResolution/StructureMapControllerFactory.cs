using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace Advertise.Common.DependencyResolution
{
    class StructureMapControllerFactory: DefaultControllerFactory
    {
        //protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        //{
        //    if (controllerType == null)
        //        throw new InvalidOperationException(string.Format("Page not found: {0}", requestContext.HttpContext.Request.Url.AbsoluteUri.ToString(CultureInfo.InvariantCulture)));
        //    return ApplicationObjectFactory.GetInstance(controllerType) as Controller;
        //}
    }
}
