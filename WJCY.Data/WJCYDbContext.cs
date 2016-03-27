using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WJCY.Core.Domain;
using WJCY.Data.Mapping;

namespace WJCY.Data
{
    public class WJCYDbContext : DbContext
    {
        public DbSet<LogSystem> LogSystems { get; set; }
        public DbSet<LogAction> LogActions { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Address> Addresses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LogActionMap());
            modelBuilder.Configurations.Add(new LogSystemMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new ProvinceMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new AddressMap());



            base.OnModelCreating(modelBuilder);
        }
    }
}
