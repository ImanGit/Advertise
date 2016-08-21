﻿using Advertise.ServiceLayer.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertise.ServiceLayer.Contracts.Companies
{
   public  interface ICompanyModeratorService : IBaseService
    {
        #region Create
        // <summary>
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

        #endregion
    }
}
