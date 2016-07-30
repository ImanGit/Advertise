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
        //public string Code { get; set; }

        /// <summary>
        /// عنوان محصول
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// تاریخ ثبت محصول
        /// </summary>
        public DateTime  RegisterDate { get; set; }

        /// <summary>
        /// آدرس محصول
        /// </summary>
        public string Location { get; set; }

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
        public Int32 VisitCount { get; set; }

        /// <summary>
        /// تعداد لایک
        /// </summary>
        public Int32? LikeCount { get; set; }

        /// <summary>
        /// آیا اپراتور محصول را تائید کرده است؟
        /// </summary>
        public bool IsAccepted { get; set; }

        /// <summary>
        /// کاربری که محصول را تائید کرده است
        /// </summary>
        public Guid? UserIdIsAccepted { get; set; }

        /// <summary>
        /// آیا محصول ویرایش شده است؟
        /// </summary>
        public bool  IsEdited { get; set; }

        /// <summary>
        /// آیا محصول پاک شده است؟
        /// </summary>
        public bool  IsDeleted { get; set; }

        /// <summary>
        /// تاریخ حذف محصول
        /// </summary>
        public DateTime  DeleteDate { get; set; }

        /// <summary>
        /// تاریخ ویرایش محصول
        /// </summary>
        public DateTime EditDate { get; set; }

        /// <summary>
        /// کد رهگیری ثبت شده
        /// </summary>
        public string QRCode { get; set; }

        #endregion

        #region NavigationProperties
        /// <summary>
        /// دسته بندی محصول
        /// </summary>
        public virtual Category  Category { get; set; }

        /// <summary>
        /// کد آدرس
        /// </summary>
        public virtual Place  Place { get; set; }

        /// <summary>
        /// کمپانی ثبت کننده محصول
        /// </summary>
        public virtual Company Company { get; set; }

        /// <summary>
        /// کاربر ثبت کننده ی محصول
        /// </summary>
        public virtual User User { get; set; }


        #endregion
    }
}
