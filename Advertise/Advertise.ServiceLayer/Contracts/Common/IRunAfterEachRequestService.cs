namespace Advertise.ServiceLayer.Contracts.Common
{
    /// <summary>
    /// اجرای وظایف بعد از اینکه درخواستی فراخوانی (ارسال) شد
    /// </summary>
    public interface IRunAfterEachRequestService : IBaseService
    {
        /// <summary>
        /// </summary>
        void Execute();
    }
}