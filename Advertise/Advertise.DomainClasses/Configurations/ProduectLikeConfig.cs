using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations
{
    public class ProduectLikeConfig : EntityTypeConfiguration<ProduectLike>
    {
        public ProduectLikeConfig()
        {
            Property(like => like.RowVersion).IsRowVersion();
        }
    }
}