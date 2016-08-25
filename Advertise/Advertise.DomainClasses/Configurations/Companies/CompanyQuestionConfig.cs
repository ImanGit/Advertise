using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations.Companies
{
    /// <summary>
    /// </summary>
    public class QuestionConfig : EntityTypeConfiguration<CompanyQuestion>
    {
        /// <summary>
        /// </summary>
        public QuestionConfig()
        {
            Property(question => question.Body).IsRequired().HasMaxLength(1000);
            Property(question => question.Title).IsRequired().HasMaxLength(100);
            Property(question => question.RowVersion).IsRowVersion();
        }
    }
}