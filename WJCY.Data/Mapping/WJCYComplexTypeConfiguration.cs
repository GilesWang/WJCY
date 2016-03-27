using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.Data.Mapping
{
    /// <summary>
    /// WJCY复杂类型配置类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class WJCYComplexTypeConfiguration<T> : ComplexTypeConfiguration<T> where T : class
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public WJCYComplexTypeConfiguration()
        {
            PostInitialize();
        }
        /// <summary>
        /// 子类构造前做的一些事
        /// </summary>
        public virtual void PostInitialize()
        {

        }
    }
}
