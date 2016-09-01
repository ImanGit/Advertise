using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Public;

namespace Advertise.DomainClasses.Configurations.Public
{
    /// <summary>
    /// </summary>
    public class StatisticConfig : EntityTypeConfiguration<Statistic>
    {
        /// <summary>
        /// </summary>
        public StatisticConfig()
        {
            Property(statistic => statistic.Browser).IsRequired().HasMaxLength(100);
            Property(statistic => statistic.Agent).IsRequired().HasMaxLength(100);
            Property(statistic => statistic.Ip).IsRequired().HasMaxLength(100);
            Property(statistic => statistic.Keyword).IsOptional().HasMaxLength(100);
            Property(statistic => statistic.SearchEngine).IsOptional().HasMaxLength(100);
            Property(statistic => statistic.RowVersion).IsRowVersion();
        }
    }
}