using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.Core.Domain
{
    /// <summary>
    /// 字典数据
    /// </summary>
    public class DictData : BaseEntity
    {
        /// <summary>
        /// 字段数据ID
        /// </summary>
        public int DictDataId { get; set; }
        /// <summary>
        /// 字典KEY
        /// </summary>
        public string DictKey { get; set; }
        /// <summary>
        /// 字典值
        /// </summary>
        public string DictValue { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 所属字典ID
        /// </summary>
        public int DictId { get; set; }
        /// <summary>
        /// 所属字典
        /// </summary>
        public Dict Dict { get; set; }
    }
}
