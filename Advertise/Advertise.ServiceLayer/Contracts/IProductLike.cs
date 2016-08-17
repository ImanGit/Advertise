namespace Advertise.ServiceLayer.Contracts
{
    /// <summary>
    /// </summary>
    public interface IProductLike
    {
        #region Create

        /// <summary>
        /// </summary>
        void Create();

        #endregion

        #region Update

        /// <summary>
        /// </summary>
        void Edit();

        #endregion

        #region Delete

        /// <summary>
        /// </summary>
        void Delete();

        #endregion

        #region Retrieve

        /// <summary>
        /// </summary>
        /// <returns></returns>
        int GetProductLikedCount();

        /// <summary>
        /// </summary>
        /// <returns></returns>
        int GetProductDisLikedCount();

        /// <summary>
        /// </summary>
        /// <returns></returns>
        int GetUserLikedCount();

        /// <summary>
        /// </summary>
        /// <returns></returns>
        int GetUserDisLikedCount();

        /// <summary>
        /// </summary>
        /// <returns></returns>
        long Count();

        #endregion
    }
}