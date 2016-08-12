using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Advertise.DataLayer.Context
{
    /// <summary>
    ///     اینترفیس مربوط به الگوی واحد کار
    /// </summary>
    public interface IUnitOfWork
    {
        bool ValidateOnSaveEnabled { get; set; }
        bool ProxyCreationEnabled { get; set; }
        bool AutoDetectChangesEnabled { get; set; }
        bool ForceNoTracking { get; set; }
        Database Database { get; }

        /// <summary>
        ///     متدی برای استفاده از الگوی مخزن توکار
        ///     EF
        /// </summary>
        /// <typeparam name="TEntity">نوع موجودیت</typeparam>
        /// <returns>IDbSet از موجودیت</returns>
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        /// <summary>
        ///     متد ذخیره سازی
        /// </summary>
        /// <returns></returns>
        int SaveChanges();

        /// <summary>
        ///     متد ذخیره سازی به صورت ناهمزمان
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangesAsync();

        /// <summary>
        ///     برای نشانه گذاری یک آبجکت که ویرایش شده است
        /// </summary>
        /// <typeparam name="TEntity">نوع موجودیت</typeparam>
        /// <param name="entity">آبجکت ارسالی</param>
        void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>
        ///     برای نشانه گذاری یک آبجکت که از کانتکس خارج  شده است
        /// </summary>
        /// <typeparam name="TEntity">نوع موجودیت</typeparam>
        /// <param name="entity">آبجکت ارسالی</param>
        void MarkAsDetached<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>
        ///     برای نشانه گذاری یک آبجکت که حذف شده است
        /// </summary>
        /// <typeparam name="TEntity">نوع موجودیت</typeparam>
        /// <param name="entity">آبجکت ارسالی</param>
        void MarkAsDeleted<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>
        ///     برای نشانه گذاری یک آبجکت که درج شده است
        /// </summary>
        /// <typeparam name="TEntity">نوع موجودیت</typeparam>
        /// <param name="entity">آبجکت ارسالی</param>
        void MarkAsAdded<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>
        ///     اجرای یک کوئری اس کیو ال
        /// </summary>
        /// <typeparam name="T">نوع داده مورد نظر خروجی</typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters">پارامتر های استفاده شده در کوئری</param>
        /// <returns></returns>
        IList<T> GetRows<T>(string sql, params object[] parameters) where T : class;

        /// <summary>
        ///     ذخیره سازی با امکان مشخص کردن تکلیف داده های کش شده
        /// </summary>
        /// <param name="invalidateCacheDependencies"></param>
        /// <returns></returns>
        int SaveAllChanges(bool invalidateCacheDependencies = true, Guid? auditUserId = null);

        /// <summary>
        ///     ذخیره سازی ناهمزمان با امکان مشخص کردن تکلیف داده های کش شده
        /// </summary>
        /// <param name="invalidateCacheDependencies"></param>
        /// <returns></returns>
        Task<int> SaveAllChangesAsync(bool invalidateCacheDependencies = true, Guid? auditUserId = null);

        /// <summary>
        ///     برای درج لیستی از موجودیت ها استفاده میشود
        /// </summary>
        /// <typeparam name="TEntity">نوع مدل</typeparam>
        /// <param name="entities">لیستی از مدل مورد نظر</param>
        void AddThisRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;

        /// <summary>
        ///     به منظور ایجاد سریع دیتابیس
        /// </summary>
        void ForceDatabaseInitialize();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        void EnableFiltering(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parameter"></param>
        /// <param name="value"></param>
        void EnableFiltering(string name, string parameter, object value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        void DisableFiltering(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        void BulkInsertData<T>(IEnumerable<T> data);

        /// <summary>
        ///     برای ویرایش ارتباط های چند به چند استفاده میشود
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="mapping"></param>
        /// <returns></returns>
        T Update<T>(T entity, Expression<Func<IUpdateConfiguration<T>, object>> mapping) where T : class, new();
    }
}