using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations.Products
{
    /// <summary>
    /// </summary>
    public class ProductLikeConfig : EntityTypeConfiguration<ProductLike>
    {
        /// <summary>
        /// </summary>
        public ProductLikeConfig()
        {
            Property(like => like.RowVersion).IsRowVersion();
        }
    }
}