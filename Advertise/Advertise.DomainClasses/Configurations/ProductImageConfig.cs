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
    public class ProductImageConfig : EntityTypeConfiguration<ProductImage >
    {
        public ProductImageConfig()
        {
            Property(productimage => productimage.Title).IsOptional().HasMaxLength(100);
            Property(productimage => productimage.FileDimension).IsRequired().HasMaxLength(10);
            Property(productimage => productimage.FileName).IsRequired().HasMaxLength(100);
            Property(productimage => productimage.FileSize).IsRequired().HasMaxLength(10);
            Property(productimage => productimage.RowVersion).IsRowVersion();
        }
    }
}
