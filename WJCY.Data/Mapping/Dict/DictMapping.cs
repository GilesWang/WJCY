using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;

namespace WJCY.Data.Mapping
{
    public class DictMapping : WJCYEntityTypeConfiguration<Dict>
    {
        public DictMapping()
        {
            ToTable("Dict");
            HasKey(q => q.DictId);
            Property(q => q.DictNameEn).IsRequired().HasMaxLength(50);
            Property(q => q.DictNameCn).IsRequired().HasMaxLength(100);
        }
    }
}
