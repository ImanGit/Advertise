using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Public;

namespace Advertise.DomainClasses.Configurations.Public
{
    /// <summary>
    /// </summary>
    public class NewsConfig : EntityTypeConfiguration<News>
    {
        /// <summary>
        /// </summary>
        public NewsConfig()
        {
            Property(news => news.Message).IsRequired().HasMaxLength(1000);
            Property(news => news.Title).IsOptional().HasMaxLength(100);
            Property(news => news.RowVersion).IsRowVersion();
        }
    }
}