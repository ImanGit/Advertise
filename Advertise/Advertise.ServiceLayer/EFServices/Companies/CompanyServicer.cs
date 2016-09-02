using System;
using System.Data.Entity;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.ServiceLayer.Contracts.Companies;

namespace Advertise.ServiceLayer.EFServices.Companies
{
    public class CompanyServicer : ICompanyrService
    {
        public DbSet<Company> _c;

        public void Create()
        {
            var cd = new Company();
            //cd.Images.Add();

            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public bool EditForActiveOrDeActive()
        {
            throw new NotImplementedException();
        }

        public void RecoveryDeleted()
        {
            throw new NotImplementedException();
        }

        public void EditCopamanyCategory()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void DeleteHard()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetOneComp()
        {
            throw new NotImplementedException();
        }

        public void GetManyComp()
        {
            throw new NotImplementedException();
        }

        public void GetByDate()
        {
            throw new NotImplementedException();
        }

        public void GetCountByDate()
        {
            throw new NotImplementedException();
        }

        public void GetCompanyInCategory()
        {
            throw new NotImplementedException();
        }

        public void GetCountCompanyInCategory()
        {
            throw new NotImplementedException();
        }

        public void GetPageList()
        {
            throw new NotImplementedException();
        }

        public void GetInDB()
        {
            throw new NotImplementedException();
        }

        public int GetActive()
        {
            throw new NotImplementedException();
        }

        public int GetForSearch()
        {
            throw new NotImplementedException();
        }

        public int GetDeleted()
        {
            throw new NotImplementedException();
        }

        public int Find()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }
    }
}