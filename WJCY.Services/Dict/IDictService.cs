using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;
using WJCY.Core.Page;

namespace WJCY.Services
{
    public partial interface IDictService
    {
        /// <summary>
        /// 根据字典ID获取字典详细信息
        /// </summary>
        /// <param name="Id">字典ID</param>
        /// <returns>字典详细信息</returns>
        Dict GetDictById(int Id);
        /// <summary>
        /// 添加字典
        /// </summary>
        /// <param name="dict">字典信息</param>
        void InsertDict(Dict dict);
        /// <summary>
        /// 删除字典
        /// </summary>
        /// <param name="dict">字典信息</param>
        void DeleteDict(Dict dict);
        /// <summary>
        /// 更改字典信息
        /// </summary>
        /// <param name="dict">字典信息</param>
        void UpdateDict(Dict dict);
        /// <summary>
        /// 根据条件获取分页的字典表
        /// </summary>
        /// <param name="dictName">字典名（英文或中文），模糊查询</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页的记录数</param>
        /// <returns>分页</returns>
        IPagedList<Dict> GetDictBy(string dictName, int pageIndex = 0, int pageSize = int.MaxValue);
    }
}
