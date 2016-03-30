using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;

namespace WJCY.Data.Mapping
{
    public class DictDataMapping : WJCYEntityTypeConfiguration<DictData>
    {
        public DictDataMapping()
        {
            ToTable("DictData");
            HasKey(q => q.DictDataId);
            Property(q => q.DictKey).IsRequired().HasMaxLength(15);
            Property(q => q.DictValue).IsRequired().HasMaxLength(50);
            HasRequired(q => q.Dict).WithMany(q => q.DictDataList).HasForeignKey(q => q.DictId);
        }
    }
}
