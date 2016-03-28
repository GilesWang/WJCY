using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;

namespace WJCY.Data.Mapping
{
    public class AddressMap : WJCYEntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            ToTable("Address", "dbo");
            HasKey(t => t.AddressId);
            HasOptional(t => t.State).WithMany().HasForeignKey(t => t.StateId).WillCascadeOnDelete(false);
            HasOptional(t => t.Province).WithMany().HasForeignKey(t => t.ProvinceId).WillCascadeOnDelete(false);
            HasOptional(t => t.City).WithMany().HasForeignKey(t => t.CityId).WillCascadeOnDelete(false);
            HasOptional(t => t.Country).WithMany().HasForeignKey(t => t.CountryId).WillCascadeOnDelete(false);
            Property(t => t.DetailAddress).HasMaxLength(150).IsRequired();
            Ignore(t => t.FullAddress);
            Map<VipAddress>(m => { m.ToTable("VipAddress"); m.MapInheritedProperties(); });
        }
    }
}
