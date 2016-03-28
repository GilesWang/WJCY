using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;
namespace WJCY.Data.Mapping
{
    public class VipMap : WJCYEntityTypeConfiguration<Vip>
    {
        public VipMap()
        {
            ToTable("Vips");
            HasKey(t => t.VipId);
        }
    }
}
