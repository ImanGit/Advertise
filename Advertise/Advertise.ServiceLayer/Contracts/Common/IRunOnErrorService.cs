namespace Advertise.ServiceLayer.Contracts.Common
{
    /// <summary>
    /// اجرای وظایف در زمان بروز خطا یا استثناء‌های مدیریت نشده‌ی برنامه
    /// </summary>
    public interface IRunOnErrorService : IBaseService
    {
        /// <summary>
        /// </summary>
        void Execute();
    }
}