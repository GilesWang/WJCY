using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WJCY.Core.Domain;

namespace WJCY.Data
{
    public class WJCYDbContext : DbContext
    {
        public DbSet<LogSystem> LogSystems { get; set; }
        public DbSet<LogAction> LogActions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogSystem>().Property(d => d.LogSystemName).IsRequired().HasMaxLength(50).HasColumnName("SystemName");
            modelBuilder.Entity<LogSystem>().Property(d => d.LogSystemId).HasColumnName("SystemId");
            modelBuilder.Entity<LogSystem>().ToTable("LogSystem");

            modelBuilder.Entity<LogAction>().ToTable("LogAction");
            modelBuilder.Entity<LogAction>().Property(q => q.Name).HasColumnName("ActionName").IsRequired().HasMaxLength(15);




            base.OnModelCreating(modelBuilder);
        }
    }
}
