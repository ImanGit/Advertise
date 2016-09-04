namespace Advertise.ServiceLayer.Contracts.Common
{
    /// <summary>
    /// اجرای وظایف در زمان بارگذاری اولیه‌ی برنامه
    /// </summary>
    public interface IRunAtInitService : IBaseService
    {
        /// <summary>
        /// </summary>
        void Execute();
    }
}