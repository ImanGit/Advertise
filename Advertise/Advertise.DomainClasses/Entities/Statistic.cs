using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    ///     نشان دهنده آمار بازدید سایت
    /// </summary>
    public class Statistic : BaseEntity
    {
        #region Ctor

        /// <summary>
        ///     سازنده پیش فرض
        /// </summary>
        public Statistic()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        ///     آی پی کاربری که وارد سایت شده
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        ///     زمانی که وارد سایت شدند
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        ///     با چه Browser  ی وارد سایت شدند
        /// </summary>
        public string Browser { get; set; }

        /// <summary>
        ///     از طریق کدام موتور جستجو وارد شده اند
        /// </summary>
        public string SearchEngine { get; set; }

        /// <summary>
        ///     با زدن چه کلمه ای سایت را سرچ کرده اند
        /// </summary>
        public string Keyword { get; set; }

        #endregion

        #region NavigationProperties

        #endregion
    }
}