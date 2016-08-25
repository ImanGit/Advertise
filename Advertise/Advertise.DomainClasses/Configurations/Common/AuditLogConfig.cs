﻿using System.Data.Entity.ModelConfiguration;
using Advertise.DomainClasses.Entities.Common;

namespace Advertise.DomainClasses.Configurations.Common
{
    /// <summary>
    /// </summary>
    public class AuditLogConfig : EntityTypeConfiguration<AuditLog>
    {
        /// <summary>
        /// </summary>
        public AuditLogConfig()
        {
            Property(log => log.RowVersion).IsRowVersion();
        }
    }
}