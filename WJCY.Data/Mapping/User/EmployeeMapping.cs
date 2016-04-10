using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;

namespace WJCY.Data.Mapping
{
    public class EmployeeMapping : WJCYEntityTypeConfiguration<Employee>
    {
        public EmployeeMapping()
        {
            ToTable("Employees");
            HasKey(q => q.EmployeeNo);
            Property(q => q.Pwd).IsRequired();
            Property(q => q.EmployeeNo).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}
