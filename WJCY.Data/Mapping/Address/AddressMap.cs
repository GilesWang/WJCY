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
            ToTable("Address");
            HasKey(t => t.AddressId);
            //HasOptional(t => t.State).WithOptionalDependent();
            //HasOptional(t => t.Province).WithOptionalDependent();
            //HasOptional(t => t.City).WithOptionalDependent();
            //HasOptional(t => t.Country).WithOptionalDependent();
            Property(t => t.DetailAddress).HasMaxLength(150).IsRequired();
            Property(t => t.FullAddress).HasMaxLength(200).IsRequired();
        }
    }
}
