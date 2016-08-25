using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Companies;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// </summary>
    public class QuestionConfig : EntityTypeConfiguration<CompanyQuestion>
    {
        /// <summary>
        /// </summary>
        public QuestionConfig()
        {
            Property(question => question.Body).IsRequired().HasMaxLength(700);
            Property(question => question.CreatedOn).IsRequired();
            Property(question => question.IsApproved).IsRequired();
            Property(question => question.Title).IsRequired().HasMaxLength(255);
            Property(question => question.RowVersion).IsRowVersion();

            // Self Referencing Entity
            //HasOptional(question => question.Reply).WithMany().WillCascadeOnDelete(true);
        }
    }
}