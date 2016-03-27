using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.Core.Domain
{
    /// <summary>
    /// 县城或者区
    /// </summary>
    public class Country
    {
        /// <summary>
        /// ID
        /// </summary>
        public int CountyId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string CountryName { get; set; }
        /// <summary>
        /// 所属城市
        /// </summary>
        public City City { get; set; }
        /// <summary>
        /// 城市ID
        /// </summary>
        public int CityId { get; set; }
    }
}
