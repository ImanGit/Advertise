using Advertise.ServiceLayer.Contracts.Common;
using Advertise.ViewModel.Models.Companies;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanyService : IBaseService
    {
        #region Create

        /// <summary>
        /// 
        /// </summary>
        Task CreateAsync(CompanyCreateViewModel  viewModel);

        #endregion

        #region Update

        /// <summary>
        /// ویرایش کمپانی
        /// </summary>
        Task EditAsync(CompanyEditViewModel  viewModel);

        /// <summary>
        /// فعال یا غیر فعال کردن کمپانی
        /// </summary>
        /// <returns></returns>
        bool EditForActiveOrDeActive();

        /// <summary>
        /// برگرداندن کمپانی حذف شده
        /// </summary>
        void RecoveryDeleted();

        /// <summary>
        /// ویرایش عنوان محصولات
        /// </summary>
        void EditCopamanyCategory();

        #endregion


        #region Delete

        /// <summary>
        /// حذف منطقی 
        /// </summary>
        Task DeleteAsync(CompanyDeleteViewModel   viewModel);

        /// <summary>
        /// حذف فیزیکی
        /// </summary>
        void DeleteHard();

        #endregion

        #region Retrieve

        /// <summary>
        ///گرفتن کل کمپانی ها 
        /// </summary>
        void GetAll();

        /// <summary>
        /// گرفتن یک کمپانی
        /// </summary>
        void GetOneComp();

        /// <summary>
        /// گرفتن تعدادی کمپانی جهت مقایسه
        /// </summary>
        void GetManyComp();

        /// <summary>
        /// گرفتن کمپانی ها برا اساس تاریخ
        /// </summary>
        void GetByDate();

        /// <summary>
        /// گرفتن تعداد کمپانی ها بر اساس تاریخ
        /// </summary>
        void GetCountByDate();

        /// <summary>
        /// گرفتن کمپانی های یک محصول
        /// </summary>
        void GetCompanyInCategory();

        /// <summary>
        /// گرفتن تعداد کمپانی های یک محصول
        /// </summary>
        void GetCountCompanyInCategory();

        /// <summary>
        /// صفحه بندی 
        /// </summary>
        void GetPageList();

        /// <summary>
        /// موجود بودن کمپانی در دیتابیس
        /// </summary>
        void GetInDb();

        /// <summary>
        /// نمایش کمپانی های فعال
        /// </summary>
        /// <returns></returns>
        int GetActive();



        /// <summary>
        /// نمایش کمپانی هایی که به صورت منطقی پاک شده اند
        /// </summary>
        /// <returns></returns>
        int GetDeleted();

        #endregion

        #region Find

        /// <summary>
        /// برای 
        /// </summary>
        /// <returns></returns>
        /// <summary>
        /// جهت سرچ
        /// </summary>
        /// <returns></returns>
        int Find();
        


        #endregion


        #region Read

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<CompanyCreateViewModel> GetForCreateAsync();

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CompanyEditViewModel> GetForEditAsync(Guid id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<CompanyDeleteViewModel> GetForDeleteAsync(Guid id);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CompanyListViewModel>> GetListAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CompanyDetailsViewModel> GetDetailsAsync(Guid id);

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CompanyListViewModel> FindById(Guid id);

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        Task FillCreateViewModel(CompanyCreateViewModel viewModel);

        #endregion
    }
}