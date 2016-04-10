using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core;

namespace WJCY.Data
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        #region Fields
        private DbContext context = null;
        private IDbSet<T> _entities = null;
        #endregion

        #region ctor
        public EfRepository()
        {
            context = new WJCYDbContext();
        }
        #endregion

        #region Properties
        public IDbSet<T> Entities
        {
            get
            {

                if (_entities == null)
                {
                    _entities = context.Set<T>();
                    return _entities;
                }
                return _entities;
            }
        }
        #endregion

        public IQueryable<T> Table
        {
            get
            {
                return this.Entities;
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
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            foreach (var entity in entities)
            {
                this.Entities.Remove(entity);
            }
            this.context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.Entities.Remove(entity);
            context.SaveChanges();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            foreach (var entity in entities)
                this.Entities.Add(entity);
            this.context.SaveChanges();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.Entities.Add(entity);
            this.context.SaveChanges();
        }

        public void Update(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            this.context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.context.SaveChanges();
        }
    }
}
