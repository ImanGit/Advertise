using System;
using Advertise.DomainClasses.Entities.Categories;
using Advertise.DomainClasses.Entities.Common;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Entities.Products
{
    /// <summary>
    ///     نشان دهنده محصول
    /// </summary>
    public class Product : BaseEntity
    {
        #region Properties

        ///// <summary>
        ///// کد محصول
        ///// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        ///     عنوان محصول
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        ///     محتوای محصول
        /// </summary>
        public virtual string Body { get; set; }

        /// <summary>
        ///     آدرس محصول
        /// </summary>
        public virtual string Address { get; set; }

        /// <summary>
        ///     شماره همراه
        /// </summary>
        public virtual string MobileNumber { get; set; }

        /// <summary>
        ///     شماره ثابت
        /// </summary>
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        ///     ایمیل
        /// </summary>
        public virtual string Email { get; set; }

        /// <summary>
        ///     آیا اپراتور محصول را تائید کرده است؟
        /// </summary>
        public virtual bool IsApproved { get; set; }

        /// <summary>
        /// امکان نظر دهی به پست
        /// </summary>
        public virtual bool IsAllowComment { get; set; }

        /// <summary>
        /// امکان نظر دهی به پست برای افراد ناشناس
        /// </summary>
        public virtual bool IsAllowCommentForAnonymous { get; set; }

        /// <summary>
        /// امکان به اشتراک گذاری آن در شبکه‌های اجتماعی
        /// </summary>
        public virtual bool IsEnableForShare { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     دسته بندی محصول
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CategoryId { get; set; }

        /// <summary>
        ///     کد آدرس
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CityId { get; set; }

        /// <summary>
        ///     کمپانی ثبت کننده محصول
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CompanyId { get; set; }

        /// <summary>
        ///     کاربر ثبت کننده ی محصول
        /// </summary>
        public virtual User Owner { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid OwnerId { get; set; }

        /// <summary>
        ///     کاربری که محصول را تائید کرده است
        /// </summary>
        public virtual User Approver { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ApproverId { get; set; }

        #endregion
    }
}