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
    public partial class DictDataService : IDictDataService
    {
        #region Fields
        private IRepository<DictData> _dictDataRepository;
        #endregion

        #region Ctor
        public DictDataService(IRepository<DictData> dictDataRepository)
        {
            _dictDataRepository = dictDataRepository;
        }
        #endregion

        public void DeleteDictData(DictData dictData)
        {
            if (dictData == null)
            {
                throw new ArgumentNullException("dictData");
            }
            dictData.IsDelete = true;
            UpdateDictData(dictData);
        }

        public DictData GetDictDataBy(int dictId, string dictKey)
        {
            if (dictId == 0 || string.IsNullOrWhiteSpace(dictKey))
            {
                return null;
            }
            var query = _dictDataRepository.Table.Where(q => q.DictId == dictId && q.DictKey == dictKey);
            return query.FirstOrDefault();
        }

        public DictData GetDictDataById(int Id)
        {
            if (Id == 0)
            {
                return null;
            }
            var query = _dictDataRepository.Table.Where(q => q.DictDataId == Id);
            return query.FirstOrDefault();
        }

        public IPagedList<DictData> GetDictDataListBy(int dictId, int pageIndex = 0, int pageSize = int.MaxValue)
        {
            if (dictId <= 0 || pageIndex < 0 || pageSize < 0)
            {
                return null;
            }
            var query = _dictDataRepository.Table.Where(q => q.DictId == dictId);
            var dictDataList = new PagedList<DictData>(query, pageIndex, pageSize);
            return dictDataList;
        }

        public void InsertDictData(DictData dictData)
        {
            if (dictData == null)
            {
                throw new ArgumentNullException("dictData");
            }
            _dictDataRepository.Insert(dictData);
        }

        public void UpdateDictData(DictData dictData)
        {
            if (dictData == null)
            {
                throw new ArgumentNullException("dictData");
            }
            _dictDataRepository.Update(dictData);
        }
    }
}
