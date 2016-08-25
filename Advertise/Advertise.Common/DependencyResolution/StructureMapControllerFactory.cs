using System.Web.Mvc;

namespace Advertise.Common.DependencyResolution
{
    internal class StructureMapControllerFactory : DefaultControllerFactory
    {
        //protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        //{
        //    if (controllerType == null)
        //        throw new InvalidOperationException(string.Format("Page not found: {0}", requestContext.HttpContext.Request.Url.AbsoluteUri.ToString(CultureInfo.InvariantCulture)));
        //    return ApplicationObjectFactory.GetInstance(controllerType) as Controller;
        //}
    }
}