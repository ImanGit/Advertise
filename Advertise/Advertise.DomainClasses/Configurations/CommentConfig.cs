using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class CommentConfig: EntityTypeConfiguration<Comment>
    {
        /// <summary>
        /// 
        /// </summary>
        public CommentConfig()
        {
            Property(comment => comment.Content).IsRequired().HasMaxLength(500);
            Property(comment => comment.RowVersion).IsRowVersion();
        }
    }
}
