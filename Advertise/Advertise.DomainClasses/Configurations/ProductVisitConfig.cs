using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using System.Threading.Tasks;

using Advertise.DomainClasses.Entities;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations
{
    public class ProductVisitConfig : EntityTypeConfiguration<ProductVisit>
    {
        public ProductVisitConfig()
        {
            Property(productVisit => productVisit.RowVersion).IsRowVersion();
        }
    }
}
