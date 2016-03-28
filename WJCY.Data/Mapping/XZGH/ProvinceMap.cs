using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;

namespace WJCY.Data.Mapping
{
    public class ProvinceMap : WJCYEntityTypeConfiguration<Province>
    {
        public ProvinceMap()
        {
            ToTable("Provinces");
            HasKey(t => t.ProvinceId);
            Property(t => t.ProvinceName).HasMaxLength(30);
            HasRequired(t => t.State).WithMany().HasForeignKey(t => t.StateId);
        }
    }
}
