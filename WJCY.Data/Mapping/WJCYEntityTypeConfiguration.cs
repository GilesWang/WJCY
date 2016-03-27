using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.Data.Mapping
{
    public abstract class WJCYEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        public WJCYEntityTypeConfiguration()
        {
            //添加此虚方法供子类做一些初始化之前的事情
            PostInitialize();
        }

        internal virtual void PostInitialize()
        {

        }
    }
}
