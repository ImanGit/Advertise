using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations.Products
{
    /// <summary>
    /// </summary>
    public class ProductImageConfig : EntityTypeConfiguration<ProductImage>
    {
        /// <summary>
        /// </summary>
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