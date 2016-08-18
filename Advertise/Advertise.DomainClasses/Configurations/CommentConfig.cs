using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// </summary>
    public class CommentConfig : EntityTypeConfiguration<ProductComment>
    {
        /// <summary>
        /// </summary>
        public CommentConfig()
        {
            Property(comment => comment.Content).IsRequired().HasMaxLength(500);
            Property(comment => comment.RowVersion).IsRowVersion();
        }
    }
}