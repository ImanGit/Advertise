using Advertise.ServiceLayer.Contracts.Common;

namespace Advertise.ServiceLayer.Contracts.Categories
{
    public interface ICategoryServicer :IBaseService 
    {
        #region Create
        /// <summary>
        /// 
        /// </summary>
        void Create();

        #endregion

        #region Edit
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
        void Retrieve();

        #endregion
    }
}