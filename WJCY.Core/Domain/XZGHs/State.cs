using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.Core.Domain
{
    /// <summary>
    /// 国家
    /// </summary>
    public class State
    {
        /// <summary>
        /// 行政规划ID
        /// </summary>
        public int StateId { get; set; }
        /// <summary>
        /// 行政规划名称
        /// </summary>
        public string StateName { get; set; }
    }
}
