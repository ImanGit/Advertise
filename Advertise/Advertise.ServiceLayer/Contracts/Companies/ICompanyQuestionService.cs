using Advertise.ServiceLayer.Contracts.Common;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanyQuestionService : IBaseService
    {
        #region Create

        /// <summary>
        /// 
        /// </summary>
        void Create();

        #endregion

        #region Update

        /// <summary>
        /// تائید کردن پرسش و پاسخ
        /// </summary>
        bool EditForApprove();



        #endregion

        #region Delete

        /// <summary>
        /// 
        /// </summary>
        void Delete();

        #endregion

        #region Retrieve

        /// <summary>
        /// تعداد پرسش و پاسخهایی که تائید شدن
        /// </summary>
        void GetCountNotApprove();

        /// <summary>
        /// تعداد پرسش و پاسخهایی که تائید نشدن
        /// برای این منظور باید سه مدل باشه
        /// 0- نشان دهنده اینه که نه تائید شده نه تائید نشده
        /// 1- یعنی تائید شده
        /// -1 - یعنی تائید نشده
        /// </summary>
        void GetCountApprove();

        /// <summary>
        /// تعداد پرسش و پاسخهای با وضیعت نامشخص
        /// </summary>
        /// <returns></returns>
        int GetCountUnknown();

        /// <summary>
        /// نمایش پرسش و پاسخهایی که تائید شدن
        /// </summary>
        /// <returns></returns>
        int GetNotApprove();

        /// <summary>
        /// نمایش پرسش و پاسخهایی که تائید نشدن
        /// </summary>
        void GetApprove();

        /// <summary>
        /// نمایش پرسش و پاسخهای با وضیعت نامشخص
        /// </summary>
        /// <returns></returns>
        int GetUnknown();


        #endregion
    }
}