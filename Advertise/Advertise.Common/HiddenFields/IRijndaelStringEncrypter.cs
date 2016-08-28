using System;

namespace Advertise.Common.HiddenFields
{
    /// <summary>
    /// </summary>
    public interface IRijndaelStringEncrypter : IDisposable
    {
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        string Encrypt(string value);

        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        string Decrypt(string value);
    }
}