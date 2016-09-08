using System;
using Advertise.ServiceLayer.Contracts.Common;
namespace Advertise.ServiceLayer.Contracts.Companies
{
    public interface ICompanySocialService :IBaseService 
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
        long GetCountAll();

        int GetCountTwitter();

        int GetCountFaceBook();

        int GetCountGooglePlus();

        int GetCountYoutube();

        int GetCountAllSocialComany();

        #endregion
    }
}