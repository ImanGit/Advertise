namespace Advertise.ServiceLayer.Contracts.Common
{
    /// <summary>
    /// اجرای وظایف در ابتدای هر درخواست
    /// </summary>
    public interface IRunOnEachRequestService : IBaseService
    {
        /// <summary>
        /// </summary>
        void Execute();
    }
}