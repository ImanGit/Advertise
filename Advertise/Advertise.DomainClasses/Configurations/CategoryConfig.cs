using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advertise.DomainClasses.Entities ;
using Advertise.DomainClasses.Entities.Categories;

namespace Advertise.DomainClasses.Configurations
{
    public  class CategoryConfig:EntityTypeConfiguration< Category >
    {
        public CategoryConfig()
        {
            Property(category => category.Title).IsRequired().HasMaxLength(100);
            Property(category => category.Description ).IsRequired().HasMaxLength(1000);
            Property(category => category.Code ).IsRequired().HasMaxLength(100);
            Property(category => category.RowVersion).IsRowVersion();
        }
    }
}
