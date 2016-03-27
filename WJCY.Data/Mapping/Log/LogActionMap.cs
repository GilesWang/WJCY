using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;

namespace WJCY.Data.Mapping
{
    public class LogActionMap : WJCYEntityTypeConfiguration<LogAction>
    {
        public LogActionMap()
        {
            ToTable("LogAction");
            Property(q => q.LogActionId).HasColumnName("ActionId");
            Property(q => q.Name).HasColumnName("ActionName").IsRequired().HasMaxLength(50);
            HasKey(q => q.LogActionId);
            HasRequired(t => t.System).WithMany(t => t.Actions).HasForeignKey(t => t.SystemId);
        }
    }
}
