using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core;

namespace WJCY.Data
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        public IQueryable<T> Table
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IQueryable<T> TableNoTracking
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Delete(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
