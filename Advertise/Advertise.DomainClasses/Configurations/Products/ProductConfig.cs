using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Products;

namespace Advertise.DomainClasses.Configurations
{
    /// <summary>
    /// </summary>
    public class ProductConfig : EntityTypeConfiguration<Product>
    {
        /// <summary>
        /// </summary>
        public ProductConfig()
        {
            //ToTable("AD_Product");

            Property(product => product.Address).IsOptional().HasMaxLength(255);
            Property(product => product.Code).IsRequired().HasMaxLength(50);
            Property(product => product.CreateDate).IsRequired();
            Property(product => product.DeleteDate).IsOptional();
            Property(product => product.Description).IsOptional().HasMaxLength(500);
            Property(product => product.EditDate).IsOptional();
            Property(product => product.Email).IsOptional().HasMaxLength(100);
            Property(product => product.IsAccepted).IsRequired();
            Property(product => product.IsDeleted).IsRequired();
            Property(product => product.IsEdited).IsRequired();
            Property(product => product.LikedCount).IsOptional();
            Property(product => product.MobileNumber).IsRequired().HasMaxLength(10);
            Property(product => product.PhoneNumber).IsOptional().HasMaxLength(10);
            Property(product => product.Title).IsRequired().HasMaxLength(250);
            Property(product => product.VisitedCount).IsOptional();
            Property(product => product.RowVersion).IsRowVersion();


            //HasRequired(product=>product.AcceptUser).WithMany(user=>user.Products).WillCascadeOnDelete(false);
            //HasRequired(product => product.CreateUser).WithMany(user => user.Products).WillCascadeOnDelete(false);
        }
    }
}