using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations.Products
{
    /// <summary>
    /// </summary>
    internal class CommentLikeConfig : EntityTypeConfiguration<ProductCommentLike>
    {
        /// <summary>
        /// </summary>
        public CommentLikeConfig()
        {
            Property(commentlike => commentlike.RowVersion).IsRowVersion();
        }
    }
}