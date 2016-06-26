using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts
{
    /// <summary>
    /// نشان دهنده الزامات ارائه دهنده سرویس کاربر
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// درج کاربر جدید
        /// </summary>
        void Create();

        /// <summary>
        /// برگرداندن تعداد کاربران
        /// </summary>
        /// <returns></returns>
        long Count();
    }
}
