using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.Core.Domain
{
    /// <summary>
    /// 字典表
    /// </summary>
    public class Dict : BaseEntity
    {
        /// <summary>
        /// 字典ID
        /// </summary>
        public int DictId { get; set; }
        /// <summary>
        /// 字典名称（英文）
        /// </summary>
        public string DictNameEn { get; set; }
        /// <summary>
        /// 字典名称（中文）
        /// </summary>
        public string DictNameCn { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 字典数据集合
        /// </summary>
        public List<DictData> DictDataList { get; set; }
    }
}
