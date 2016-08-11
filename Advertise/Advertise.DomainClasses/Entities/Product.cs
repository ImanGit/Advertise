using System;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Entities
{
    /// <summary>
    /// نشان دهنده محصول
    /// </summary>
    public class Product : BaseEntity
    {
        #region Ctor

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Product()
        {
            Id = Guid.NewGuid();
            IsAccepted = false;
            IsDeleted = false;
            IsEdited = false;
        }

        #endregion

        #region Properties

        ///// <summary>
        ///// کد محصول
        ///// </summary>
        public string Code { get; set; }

        /// <summary>
        /// عنوان محصول
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// تاریخ ثبت محصول
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// آدرس محصول
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// شماره همراه
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// شماره ثابت
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// ایمیل
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// توضیحات محصول
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// تعداد دفعات مشاهده
        /// </summary>
        public Int32? VisitedCount { get; set; }

        /// <summary>
        /// تعداد لایک
        /// </summary>
        public Int32? LikedCount { get; set; }

        /// <summary>
        /// آیا اپراتور محصول را تائید کرده است؟
        /// </summary>
        public bool IsAccepted { get; set; }

        /// <summary>
        /// آیا محصول ویرایش شده است؟
        /// </summary>
        public bool IsEdited { get; set; }

        /// <summary>
        /// آیا محصول پاک شده است؟
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// تاریخ حذف محصول
        /// </summary>
        public DateTime? DeleteDate { get; set; }

        /// <summary>
        /// تاریخ ویرایش محصول
        /// </summary>
        public DateTime? EditDate { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid CategoryId { get; set; }

        /// <summary>
        /// دسته بندی محصول
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid CityId { get; set; }

        /// <summary>
        /// کد آدرس
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid CompanyId { get; set; }

        /// <summary>
        /// کمپانی ثبت کننده محصول
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid CreateUserId { get; set; }

        /// <summary>
        /// کاربر ثبت کننده ی محصول
        /// </summary>
        public virtual User CreateUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid AcceptUserId { get; set; }

        /// <summary>
        /// کاربری که محصول را تائید کرده است
        /// </summary>
        public virtual User AcceptUser { get; set; }

        #endregion
    }
}
