using Advertise.ServiceLayer.Contracts.Common;

namespace Advertise.ServiceLayer.Contracts
{
    /// <summary>
    ///     نشان دهنده الزامات ارائه دهنده سرویس کاربر
    /// </summary>
    public interface IUserService : IBaseService
    {
        /// <summary>
        ///     درج کاربر جدید
        /// </summary>
        void Create();

        /// <summary>
        ///     برگرداندن تعداد کاربران
        /// </summary>
        /// <returns></returns>
        long Count();
    }
}