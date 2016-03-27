using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;

namespace WJCY.Data.Mapping
{
    public class LogSystemMap : WJCYEntityTypeConfiguration<LogSystem>
    {
        public LogSystemMap()
        {
            this.ToTable("LogSystem");
            this.HasKey(q => q.LogSystemId);
            this.Property(p => p.LogSystemName).HasColumnName("SystemName").IsRequired().HasMaxLength(50);
            this.Property(p => p.LogSystemId).HasColumnName("SystemId").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            HasMany(t => t.Actions).WithRequired(t => t.System);
        }
    }
}
