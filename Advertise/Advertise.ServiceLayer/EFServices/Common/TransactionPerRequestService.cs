using System.Data;
using System.Data.Entity;
using System.Web;
using Advertise.DataLayer.Context;
using Advertise.ServiceLayer.Contracts.Common;

namespace Advertise.ServiceLayer.EFServices.Common
{
    /// <summary>
    /// </summary>
    public class TransactionPerRequestService : IRunOnEachRequestService, IRunOnErrorService, IRunAfterEachRequestService
    {
        #region Ctor

        /// <summary>
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="httpContext"></param>
        public TransactionPerRequestService(IUnitOfWork unitOfWork, HttpContextBase httpContext)
        {
            _unitOfWork = unitOfWork;
            _httpContext = httpContext;
        }

        #endregion

        #region Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly HttpContextBase _httpContext;
        private const string Transaction = "_Transaction";
        private const string Error = "_Error";

        #endregion

        #region Interfaces

        /// <summary>
        /// </summary>
        void IRunOnEachRequestService.Execute()
        {
            _httpContext.Items[Transaction] =
                _unitOfWork.Database.BeginTransaction(IsolationLevel.Snapshot);
        }

        /// <summary>
        /// </summary>
        void IRunOnErrorService.Execute()
        {
            _httpContext.Items[Error] = true;
        }

        /// <summary>
        /// </summary>
        void IRunAfterEachRequestService.Execute()
        {
            var transaction = (DbContextTransaction) _httpContext.Items["_Transaction"];
            if (_httpContext.Items["_Error"] != null)
            {
                transaction.Rollback();
            }
            else
            {
                transaction.Commit();
            }
        }

        #endregion
    }
}