using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Companies;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Advertise.ServiceLayer.Contracts.Companies;
using Advertise.ViewModel.Models.Companies.CompanyVisit;
using System;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Extensions;
using System.Data.Entity;

namespace Advertise.ServiceLayer.EFServices.Companies
{
    public class CompanyVisitService : ICompanyVisitService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CompanyVisit> _companyVisit;

        #endregion

        #region Ctor

        public CompanyVisitService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _companyVisit = unitOfWork.Set<CompanyVisit>();
        }

        #endregion

        #region Create

        public async Task CreateAsync(CompanyVisitCreateViewModel  viewModel)
        {
            var companyr = _mapper.Map<CompanyVisit>(viewModel);
            _companyVisit.Add(companyr);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CompanyVisitCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CompanyVisitCreateViewModel());
        }
        #endregion

        #region Retrive
        public int GetCountAllVisitComany()
        {
            throw new NotImplementedException();
        }

        public int GetCountForToday()
        {
            throw new NotImplementedException();
        }

        public int GetCountForMonth()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}