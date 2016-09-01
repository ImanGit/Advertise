using System.Collections.Generic;
using System.Web.Mvc;
using StructureMap;

namespace Advertise.Common.DependencyResolution
{
    /// <summary>
    /// </summary>
    public class StructureMapFilterProvider : FilterAttributeFilterProvider
    {
        private readonly IContainer _container;

        /// <summary>
        /// </summary>
        /// <param name="container"></param>
        public StructureMapFilterProvider(IContainer container)
        {
            _container = container;
        }

        /// <summary>
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="actionDescriptor"></param>
        /// <returns></returns>
        public override IEnumerable<Filter> GetFilters(ControllerContext controllerContext,
            ActionDescriptor actionDescriptor)
        {
            var filters = base.GetFilters(controllerContext, actionDescriptor);
            foreach (var filter in filters)
            {
                _container.BuildUp(filter.Instance);
                yield return filter;
            }
        }
    }
}