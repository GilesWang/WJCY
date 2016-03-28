using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;

namespace WJCY.Data.Mapping
{
    public class CityMap : WJCYEntityTypeConfiguration<City>
    {
        public CityMap()
        {
            ToTable("Citys");
            HasKey(t => t.CityId);
            Property(t => t.CityName).HasMaxLength(30);
            HasRequired(t => t.Province).WithMany().HasForeignKey(t => t.ProvinceId);
        }
    }
}
