﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            var logSystem = new Core.Domain.LogSystem()
            {

                LogSystemName = "后台系统"
            };
            using (var context = new WJCYDbContext())
            {
                context.LogSystems.Add(logSystem);
                context.SaveChanges();
            }
        }
    }
}
