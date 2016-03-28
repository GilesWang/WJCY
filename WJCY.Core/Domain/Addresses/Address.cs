using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.Core.Domain
{
    /// <summary>
    /// 地址
    /// </summary>
    public class Address
    {
        public Guid AddressId { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        public State State { get; set; }
        /// <summary>
        /// 国家ID
        /// </summary>
        public int? StateId { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public Province Province { get; set; }
        /// <summary>
        /// 省份ID
        /// </summary>
        public int? ProvinceId { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public City City { get; set; }
        /// <summary>
        /// 城市Id
        /// </summary>
        public int? CityId { get; set; }
        /// <summary>
        /// 县城或区
        /// </summary>
        public Country Country { get; set; }
        /// <summary>
        /// 县城或区 名称
        /// </summary>
        public int? CountryId { get; set; }
        /// <summary>
        /// 具体地址 （包括什么路什么小区几号几0几等）
        /// </summary>
        public string DetailAddress
        {
            get; set;
        }
        /// <summary>
        /// 完整地址
        /// </summary>
        public string FullAddress
        {
            get { return State.StateName + Province.ProvinceName + City.CityName + Country.CountryName + DetailAddress; }
        }
    }
}
