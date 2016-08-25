using System.Data.Entity;
using Advertise.DomainClasses.Entities.Companies;
using Advertise.ServiceLayer.Contracts.Companies;

namespace Advertise.ServiceLayer.EFServices.Companies
{
    public class CompanyServicer:ICompanyrService
    {
        public DbSet<DomainClasses.Entities.Companies.Company> _c; 
        public void Create()
        {
            DomainClasses.Entities.Companies.Company cd=new Company();
            //cd.Images.Add();
            
            throw new System.NotImplementedException();
        }

        public void Edit()
        {
            throw new System.NotImplementedException();
        }

        public bool EditForActiveOrDeActive()
        {
            throw new System.NotImplementedException();
        }

        public void RecoveryDeleted()
        {
            throw new System.NotImplementedException();
        }

        public void EditCopamanyCategory()
        {
            throw new System.NotImplementedException();
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteHard()
        {
            throw new System.NotImplementedException();
        }

        public void GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void GetOneComp()
        {
            throw new System.NotImplementedException();
        }

        public void GetManyComp()
        {
            throw new System.NotImplementedException();
        }

        public void GetByDate()
        {
            throw new System.NotImplementedException();
        }

        public void GetCountByDate()
        {
            throw new System.NotImplementedException();
        }

        public void GetCompanyInCategory()
        {
            throw new System.NotImplementedException();
        }

        public void GetCountCompanyInCategory()
        {
            throw new System.NotImplementedException();
        }

        public void GetPageList()
        {
            throw new System.NotImplementedException();
        }

        public void GetInDB()
        {
            throw new System.NotImplementedException();
        }

        public int GetActive()
        {
            throw new System.NotImplementedException();
        }

        public int GetForSearch()
        {
            throw new System.NotImplementedException();
        }

        public int GetDeleted()
        {
            throw new System.NotImplementedException();
        }

        public void Get()
        {
            throw new System.NotImplementedException();
        }
    }
}