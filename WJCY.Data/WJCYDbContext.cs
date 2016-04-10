using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WJCY.Core.Domain;
using WJCY.Data.Mapping;
using System.Data.Common;
using System.Data.SqlClient;
using WJCY.Common;

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

        public DbSet<Dict> Dicts { get; set; }
        public DbSet<DictData> DictDatas { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LogActionMap());
            modelBuilder.Configurations.Add(new LogSystemMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new ProvinceMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new VipMap());
            modelBuilder.Configurations.Add(new DictDataMapping());
            modelBuilder.Configurations.Add(new DictMapping());
            modelBuilder.Configurations.Add(new EmployeeMapping());

            base.OnModelCreating(modelBuilder);
        }

        public WJCYDbContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<WJCYDbContext>());
            Database.Connection.ConnectionString = WJCYDbConfig.ConnectionStr;

        }
        //public WJCYDbContext() : base("WJCY")
        //{

        //}
        //public WJCYDbContext(DbConnection connection) : base(connection, contextOwnsConnection: false)
        //{

        //}
    }
}
