using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;
using WJCY.Core.Page;

namespace WJCY.Services
{
    public partial interface IDictDataService
    {
        DictData GetDictDataById(int Id);

        void InsertDictData(DictData dictData);

        void DeleteDictData(DictData dictData);

        void UpdateDictData(DictData dictData);

        /// <summary>
        /// 根据字典ID查询所有的字典数据
        /// </summary>
        /// <param name="dictId">字典ID</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">每页记录数</param>
        /// <returns>分页的字典数据</returns>
        IPagedList<DictData> GetDictDataListBy(int dictId, int pageIndex = 0, int pageSize = int.MaxValue);

        /// <summary>
        /// 根据字典ID 和字典数据key获取字典数据
        /// </summary>
        /// <param name="dictId"></param>
        /// <param name="dictKey"></param>
        /// <returns></returns>
        DictData GetDictDataBy(int dictId, string dictKey);
    }
}
