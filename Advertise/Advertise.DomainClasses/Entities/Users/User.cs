using System;
using System.Collections.Generic;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.DomainClasses.Entities.Products;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Advertise.DomainClasses.Entities.Users
{
    /// <summary>
    ///     نشان دهنده امنیت کاربر
    /// </summary>
    public class User : IdentityUser<Guid, UserLogin, UserRole, UserClaim>
    {
        #region Properties

        /// <summary>
        ///     آیا کاربر بلاک شده؟
        /// </summary>
        public virtual bool IsBanned { get; set; }

        /// <summary>
        /// </summary>
        public virtual string BannedReason { get; set; }

        /// <summary>
        /// </summary>
        public virtual DateTime? BannedOn { get; set; }

        /// <summary>
        ///     آیا کاربر تائید شده است؟
        /// </summary>
        public virtual bool IsVerified { get; set; }

        /// <summary>
        ///     آیا کاربر فعال است؟
        /// </summary>
        public virtual bool IsActive { get; set; }

        /// <summary>
        ///     آیا کاربر مهمان است؟
        /// </summary>
        public virtual bool IsAnonymous { get; set; }

        /// <summary>
        ///     توکن تائید فعال سازی ایمیل
        /// </summary>
        public virtual string EmailConfirmationToken { get; set; }

        /// <summary>
        ///     توکن تائید فغال سازی موبایل
        /// </summary>
        public virtual string MobileConfirmationToken { get; set; }

        /// <summary>
        ///     آخرین زمان تغییر پسورد
        /// </summary>
        public virtual DateTime? LastPasswordChangedOn { get; set; }

        /// <summary>
        ///     آخرین زمانی که کاربر وارد سایت شده
        /// </summary>
        public virtual DateTime? LastLoginOn { get; set; }

        /// <summary>
        /// </summary>
        public virtual bool IsSystemAccount { get; set; }

        /// <summary>
        /// </summary>
        public virtual string LastIp { get; set; }

        /// <summary>
        /// </summary>
        public virtual byte[] RowVersion { get; set; }

        #endregion

        #region NavigationProperties

        /// <summary>
        /// </summary>
        public virtual ICollection<UserBudget> Budgets { get; set; }

        /// <summary>
        /// </summary>
        public virtual UserProfile Profile { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<UserReport> Reports { get; set; }

        /// <summary>
        /// </summary>
        public virtual UserSetting Setting { get; set; }

        /// <summary>
        /// </summary>
        public virtual UserSocial Social { get; set; }


        /// <summary>
        ///     لیست محصولات کاربر
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }

        /// <summary>
        ///     لیست نظرات کاربر
        /// </summary>
        public virtual ICollection<ProductComment> ProductComments { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<ProductCommentLike> ProductsCommentLikes { get; set; }

        /// <summary>
        ///     لیست پسند های کاربر
        /// </summary>
        public virtual ICollection<ProduectLike> ProductLikes { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<ProductImage> ProductImages { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<ProductVisit> ProductVisits { get; set; }

        /// <summary>
        ///     لیست شرکت های کاربر
        /// </summary>
        public virtual ICollection<Company> Companies { get; set; }

        /// <summary>
        ///     لیست علاقه مندی های کاربر
        /// </summary>
        public virtual ICollection<CompanyFollow> CompanyFollows { get; set; }

        /// <summary>
        ///     لیست سوال های کاربر
        /// </summary>
        public virtual ICollection<CompanyQuestion> CompanyQuestions { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<CompanyVisit> CompanyVisits { get; set; }

        #endregion
    }
}