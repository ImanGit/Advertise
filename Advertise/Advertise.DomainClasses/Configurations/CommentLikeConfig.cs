using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations
{
    internal class CommentLikeConfig : EntityTypeConfiguration<ProductCommentLike>
    {
        public CommentLikeConfig()
        {
            Property(commentlike => commentlike.RowVersion).IsRowVersion();
        }
    }
}