using System;
using System.Globalization;

namespace Advertise.Mapping.Extensions
{
    /// <summary>
    /// </summary>
    public static class PersianExtension
    {
        /// <summary>
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string ToPersianDateTime(this DateTime dateTime)
        {
            var year = dateTime.Year;
            var month = dateTime.Month;
            var day = dateTime.Day;
            var persianCalendar = new PersianCalendar();
            var pYear = persianCalendar.GetYear(new DateTime(year, month, day, new GregorianCalendar()));
            var pMonth = persianCalendar.GetMonth(new DateTime(year, month, day, new GregorianCalendar()));
            var pDay = persianCalendar.GetDayOfMonth(new DateTime(year, month, day, new GregorianCalendar()));
            return string.Format("{0}{1}{2}{1}{3}", pYear, "/", pMonth.ToString("00", CultureInfo.InvariantCulture),
                pDay.ToString("00", CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ToPersianString(this DateTime dateTime,
            PersianDateTimeFormat format = PersianDateTimeFormat.ShortDateShortTime)
        {
            return new PersianDateTime(dateTime).ToString(format);
        }

        /// <summary>
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ToPersianString(this DateTime? dateTime, PersianDateTimeFormat format)
        {
            return dateTime != null ? new PersianDateTime(dateTime.Value).ToString(format) : string.Empty;
        }
    }
}