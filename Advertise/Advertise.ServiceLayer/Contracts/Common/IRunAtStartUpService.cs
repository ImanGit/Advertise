namespace Advertise.ServiceLayer.Contracts.Common
{
    /// <summary>
    /// اجرای وظایف در زمان StartUp برنامه
    /// </summary>
    public interface IRunAtStartUpService : IBaseService
    {
        /// <summary>
        /// </summary>
        void Execute();
    }
}