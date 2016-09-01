using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations.Products
{
    /// <summary>
    /// </summary>
    public class CommentConfig : EntityTypeConfiguration<ProductComment>
    {
        /// <summary>
        /// </summary>
        public CommentConfig()
        {
            Property(comment => comment.Body).IsRequired().HasMaxLength(1000);
            Property(comment => comment.RowVersion).IsRowVersion();
        }
    }
}