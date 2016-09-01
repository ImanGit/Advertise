using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Users;

namespace Advertise.DomainClasses.Configurations.Users
{
    /// <summary>
    /// </summary>
    public class UserClaimConfig : EntityTypeConfiguration<UserClaim>
    {
        /// <summary>
        /// </summary>
        public UserClaimConfig()
        {
            Property(claim => claim.RowVersion).IsRowVersion();
        }
    }
}