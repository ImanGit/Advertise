﻿using System;
using System.Data.Entity;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities;
using Advertise.ServiceLayer.Contracts;
using Advertise.ServiceLayer.EFServices.Common;
using Microsoft.AspNet.Identity;

namespace Advertise.ServiceLayer.EFServices
{
    /// <summary>
    /// </summary>
    public class UserService : UserManager<User,Guid>, IUserService
    {
        #region Ctor

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion

        #region Create

        /// <summary>
        /// </summary>
        public void Create()
        {
        }

        #endregion

        #region Count

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public long Count()
        {
            return 0;
        }

        #endregion

        #region Fields

        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<User> _users;

        #endregion
    }
}