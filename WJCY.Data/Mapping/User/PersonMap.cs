using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;

namespace WJCY.Data.Mapping
{
    public class PersonMap : WJCYComplexTypeConfiguration<Person>
    {
        public PersonMap()
        {
            Property(t => t.Name).HasColumnName("UserName").IsRequired().HasMaxLength(50);
            Property(t => t.Age).HasColumnName("UserAge").IsRequired();
            Property(t => t.BirthDate).HasColumnName("UserBirth").IsRequired();
            Property(t => t.Height).HasColumnName("UserHeight").HasPrecision(3, 2).IsRequired();
            Property(t => t.CellPhone).IsOptional().HasMaxLength(11).HasColumnName("Cellphone");
        }
    }
}
