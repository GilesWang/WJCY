using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;

namespace WJCY.Data.Mapping
{
    public class StateMap : WJCYEntityTypeConfiguration<State>
    {
        public StateMap()
        {
            this.ToTable("States");
            this.HasKey(t => t.StateId);
            this.Property(t => t.StateName).HasMaxLength(15);
        }
    }
}
