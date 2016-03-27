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
        public string StateId { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public Province Province { get; set; }
        /// <summary>
        /// 省份ID
        /// </summary>
        public string ProvinceId { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public City City { get; set; }
        /// <summary>
        /// 城市Id
        /// </summary>
        public string CityId { get; set; }
        /// <summary>
        /// 县城或区
        /// </summary>
        public Country Country { get; set; }
        /// <summary>
        /// 县城或区 名称
        /// </summary>
        public string CountryId { get; set; }
        /// <summary>
        /// 具体地址 （包括什么路什么小区几号几0几等）
        /// </summary>
        public string DetailAddress { get; set; }
        /// <summary>
        /// 完整地址
        /// </summary>
        public string FullAddress { get; set; }
        /// <summary>
        /// 地址类型（根据不同的地址类型映射到不同的表，有客户地址，供应商地址，门店地址等）
        /// </summary>
        public short AddressType { get; set; }
    }
}
