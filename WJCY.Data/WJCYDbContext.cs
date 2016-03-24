using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WJCY.Data
{
    public class WJCYDbContext : DbContext
    {
        #region ctor
        public WJCYDbContext(string nameOrConnectionString):base(nameOrConnectionString)
        {

        }
        #endregion


        #region Utilities
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
