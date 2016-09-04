using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ServiceLayer.EFServices.Users;
using StructureMap;

namespace Advertise.Common.DependencyResolution.Registeries
{
    /// <summary>
    /// </summary>
    public class ServiceLayerRegistery : Registry
    {
        /// <summary>
        /// </summary>
        public ServiceLayerRegistery()
        {
            Policies.SetAllProperties(y => { y.OfType<IActivityLogService>(); });
            Scan(scanner =>
            {
                scanner.Assembly("Advertise.ServiceLayer");
                scanner.WithDefaultConventions();
                scanner.AssemblyContainingType<UserService>();
            });
        }
    }
}