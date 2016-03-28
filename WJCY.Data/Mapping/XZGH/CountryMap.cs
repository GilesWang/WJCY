using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;

namespace WJCY.Data.Mapping
{
    public class CountryMap : WJCYEntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            ToTable("Countries");
            HasKey(t => t.CountyId);
            Property(t => t.CountryName).HasMaxLength(30);
            HasRequired(t => t.City).WithMany().HasForeignKey(t => t.CityId);
        }
    }
}
