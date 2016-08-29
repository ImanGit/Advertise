using System;
using System.Threading.Tasks;
using Advertise.ServiceLayer.Contracts.Common;
using Microsoft.Owin.Security.Cookies;

namespace Advertise.ServiceLayer.Contracts.Users


{
    /// <summary>
    ///     نشان دهنده الزامات ارائه دهنده سرویس کاربر
    /// </summary>
    public interface IUserService : IBaseService
    {
        #region Create

        /// <summary>
        /// </summary>
        void Create();

        #endregion

        #region Update

        /// <summary>
        /// </summary>
        void Edit();

        #endregion

        #region Delete

        /// <summary>
        /// </summary>
        void Delete();

        #endregion

        Func<CookieValidateIdentityContext, Task> OnValidateIdentity();

        void SeedDatabase();

        #region Retrieve

        /// <summary>
        /// </summary>
        void Get();

        /// <summary>
        ///     برگرداندن تعداد کاربران
        /// </summary>
        /// <returns></returns>
        long GetCount();

        #endregion
    }
}