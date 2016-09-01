using Advertise.ServiceLayer.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanyAttachmentService : IBaseService
    {
        #region Create

        /// <summary>
        /// 
        /// </summary>
        void Create();

        #endregion

        #region Update

        /// <summary>
        /// 
        /// </summary>
        void Edit();

        #endregion

        #region Delete

        /// <summary>
        /// 
        /// </summary>
        void Delete();

        #endregion

        #region Retrieve

        /// <summary>
        /// 
        /// </summary>
        void Get();

        /// <summary>
        /// تعداد اتچ های یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetCountCompanyAttach();

        /// <summary>
        /// نمایش اتچهای یک کمپانی
        /// </summary>
        /// <returns></returns>
        int GetOneCompanyAttach();

        /// <summary>
        /// نمایش تمام اتچ ها
        /// </summary>
        /// <returns></returns>
        int GetCompanyAttach();

        /// <summary>
        /// تعداد کل اتچها
        /// </summary>
        /// <returns></returns>
        int GetAllCount();

        /// <summary>
        /// گرفتن کد اتچ جهت نمایش
        /// </summary>
        /// <returns></returns>
        int GetAttachmentByCode();

        #endregion

        #region Find

        int Find();

        #endregion
    }
}