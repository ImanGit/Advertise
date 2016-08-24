using System;
using System.Collections.Generic;
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
        ///     امکان نظر دهی به پست
        /// </summary>
        public virtual bool IsAllowComment { get; set; }

        /// <summary>
        ///     امکان نظر دهی به پست برای افراد ناشناس
        /// </summary>
        public virtual bool IsAllowCommentForAnonymous { get; set; }

        /// <summary>
        ///     امکان به اشتراک گذاری آن در شبکه‌های اجتماعی
        /// </summary>
        public virtual bool IsEnableForShare { get; set; }

        /// <summary>
        /// </summary>
        public virtual ProductStatus Status { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        ///     کاربر ثبت کننده ی محصول
        /// </summary>
        public virtual User OwnedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid OwnedById { get; set; }

        /// <summary>
        ///     کاربری که محصول را تائید کرده است
        /// </summary>
        public virtual User ApprovedBy { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid ApprovedById { get; set; }

        /// <summary>
        ///     آدرس محصول
        /// </summary>
        public virtual Address Address { get; set; }

        /// <summary>
        ///     آدرس محصول
        /// </summary>
        public virtual Guid AddressId { get; set; }

        /// <summary>
        ///     دسته بندی محصول
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CategoryId { get; set; }

        /// <summary>
        ///     کمپانی ثبت کننده محصول
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid CompanyId { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<ProductComment> Comments { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<ProductImage> Images { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<ProduectLike> Likes { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<ProductProperty> Properties { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<ProductReport> Reports { get; set; }

        /// <summary>
        /// </summary>
        public virtual CompanyReview Review { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<ProductShare> Shares { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<ProductVisit> Visits { get; set; }

        #endregion
    }
}