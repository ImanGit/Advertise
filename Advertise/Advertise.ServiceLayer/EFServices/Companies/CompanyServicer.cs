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
            cd.Images.Add();
            _c.
            throw new System.NotImplementedException();
        }

        public void Edit()
        {
            throw new System.NotImplementedException();
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public void Get()
        {
            throw new System.NotImplementedException();
        }
    }
}