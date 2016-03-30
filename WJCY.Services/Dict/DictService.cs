using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core;
using WJCY.Core.Domain;
using WJCY.Core.Page;

namespace WJCY.Services
{
    public class DictService : IDictService
    {
        #region Fields
        private IRepository<Dict> _dictReposity;
        #endregion

        public DictService(IRepository<Dict> dictRepository)
        {
            _dictReposity = dictRepository;
        }

        public virtual void DeleteDict(Dict dict)
        {
            if (dict == null)
            {
                throw new ArgumentNullException("dict");
            }
            dict.IsDelete = true;
            UpdateDict(dict);
        }

        public virtual IPagedList<Dict> GetDictBy(string dictName, int pageIndex = 0, int pageSize = int.MaxValue)
        {
            if (pageIndex < 0 || pageSize < 0)
            {
                return null;
            }
            var query = _dictReposity.Table;
            //字典名称模糊查询
            query = string.IsNullOrWhiteSpace(dictName) ? query : query.Where(q => q.DictNameEn.Contains(dictName) || q.DictNameCn.Contains(dictName));

            //未删除的，按照创建日期降序排列
            query = query.Where(q => !q.IsDelete).OrderByDescending(q => q.CreateDate);

            var dictList = new PagedList<Dict>(query, pageIndex, pageSize);
            return dictList;
        }

        public virtual Dict GetDictById(int Id)
        {
            if (Id == 0)
            {
                return null;
            }
            return _dictReposity.Table.Where(q => q.DictId == Id && !q.IsDelete).FirstOrDefault();
        }

        public virtual void InsertDict(Dict dict)
        {
            if (dict == null)
            {
                throw new ArgumentNullException("dict");
            }
            _dictReposity.Insert(dict);
        }

        public virtual void UpdateDict(Dict dict)
        {
            if (dict == null)
            {
                throw new ArgumentNullException("dict");
            }
            _dictReposity.Update(dict);
        }
    }
}
