using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities;
namespace Advertise.DomainClasses.Configurations
{
    public  class CompanyImageConfig :EntityTypeConfiguration< CompanyImage >
    {
        public CompanyImageConfig()
        {
            Property(image => image.Title ).IsOptional().HasMaxLength(100);
            Property(image => image.FileDimension ).IsRequired() .HasMaxLength(10);
            Property(image => image.FileName ).IsRequired() .HasMaxLength(100);
            Property(image => image.FileSize ).IsRequired() .HasMaxLength(10);
            Property(image => image.RowVersion).IsRowVersion();
        }
    }
}
