using Advertise.ServiceLayer.Contracts.Common;
using StructureMap;

namespace Advertise.Common.DependencyResolution.Registeries
{
    /// <summary>
    /// </summary>
    public class TaskRegistry : Registry
    {
        /// <summary>
        /// </summary>
        public TaskRegistry()
        {
            Scan(scan =>
            {
                scan.Assembly("Advertise.ServiceLayer");
                scan.AddAllTypesOf<IRunAfterEachRequestService>();
                scan.AddAllTypesOf<IRunAtInitService>();
                scan.AddAllTypesOf<IRunAtStartUpService>();
                scan.AddAllTypesOf<IRunOnEachRequestService>();
                scan.AddAllTypesOf<IRunOnErrorService>();
            });
        }
    }
}