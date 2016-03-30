using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.Core.Page
{
    public class PagedList<T> : List<T>, IPagedList<T>
    {

        public PagedList(IEnumerable<T> source, int pageIndex, int pageSize)
        {
            Init(source, pageIndex, pageSize);
        }

        public PagedList(IEnumerable<T> source, int pageIndex, int pageSize, int totalCount)
        {
            Init(source, pageIndex, pageSize, totalCount);
        }

        private void Init(IEnumerable<T> source, int pageIndex, int pageSize, int? totalCount = null)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            if (pageSize < 0)
            {
                throw new ArgumentException("PageSize must be greater than 0");
            }

            TotalCount = totalCount ?? source.Count();
            TotalPages = TotalCount / pageSize;
            if (TotalCount % pageSize > 0)
            {
                TotalPages++;
            }

            PageSize = pageSize;
            PageIndex = pageIndex;
            source = totalCount == null ? source.Skip(PageIndex * PageSize).Take(PageSize) : source;
            AddRange(source);
        }

        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPages { get; private set; }

        public bool HasPreviousPage
        {
            get { return (PageIndex > 0); }
        }
        public bool HasNextPage
        {
            get { return (PageIndex + 1 < TotalPages); }
        }
    }
}
