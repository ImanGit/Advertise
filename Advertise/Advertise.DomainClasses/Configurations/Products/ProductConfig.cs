using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations.Products
{
    /// <summary>
    /// </summary>
    public class ProductConfig : EntityTypeConfiguration<Product>
    {
        /// <summary>
        /// </summary>
        public ProductConfig()
        {
            Property(product => product.Code).IsRequired().HasMaxLength(100);
            Property(product => product.Body).IsOptional().HasMaxLength(1000);
            Property(product => product.Email).IsOptional().HasMaxLength(100);
            Property(product => product.MobileNumber).IsRequired().HasMaxLength(10);
            Property(product => product.PhoneNumber).IsOptional().HasMaxLength(10);
            Property(product => product.Title).IsRequired().HasMaxLength(100);
            Property(product => product.RowVersion).IsRowVersion();
        }
    }
}