using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core;
using WJCY.Data;
using sysCon = System.Console;

namespace WJCY.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<WJCYDbContext>());
            sysCon.WriteLine("系统启动");
            while (true)
            {
                InsertLogSystem();
                var str = sysCon.ReadLine();
                if (str == "exit")
                {
                    break;
                }
            }
            sysCon.WriteLine("操作结束");
        }

        private static void InsertLogSystem()
        {
            var address = new WJCY.Core.Domain.Address()
            {
                AddressId = Guid.NewGuid(),
                DetailAddress = "永吉路97弄7号301"

            };
            var vipAddress = new WJCY.Core.Domain.VipAddress()
            {
                AddressId = Guid.NewGuid(),
                DetailAddress = "永吉路97弄7号301",
                VipCard = "test"
            };

            var str = @"Data Source=DESKTOP-CN5DFKO;Initial Catalog=WJCY_TEST2;Persist Security Info=True;User ID=GilesWang;pwd=wfg1990@";
            using (var connection = new SqlConnection(str))
            {
                using (var context = new WJCYDbContext(connection))
                {
                    context.Addresses.Add(address);
                    context.SaveChanges();
                }



                using (var context = new WJCYDbContext(connection))
                {
                    context.Addresses.Add(vipAddress);
                    context.SaveChanges();
                }
            }
        }
    }
}
