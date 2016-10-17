using System.Collections.Generic;
using System.Linq;

namespace Advertise.Utility.Extensions
{
    /// <summary>
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool HasValue(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNotEmpty(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        #region GetUserManagerErros

        /// <summary>
        /// </summary>
        /// <param name="errors"></param>
        /// <returns></returns>
        public static string GetUserManagerErros(this IEnumerable<string> errors)
        {
            return errors.Aggregate(string.Empty, (current, error) => current + $"{error} \n");
        }

        #endregion
    }
}