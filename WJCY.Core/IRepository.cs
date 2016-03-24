using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.Core
{
    public partial interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Get entity by identifier
        /// </summary>
        /// <param name="id">identifier</param>
        /// <returns>Entity</returns>
        T GetById(object id);
        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity to be inserted</param>
        void Insert(T entity);
        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities">Entities to be inserted</param>
        void Insert(IEnumerable<T> entities);
        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity to be updated</param>
        void Update(T entity);
        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities to be updated</param>
        void Update(IEnumerable<T> entities);
        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity">Entity to be deleted</param>
        void Delete(T entity);
        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities">Entities to be deleted</param>
        void Delete(IEnumerable<T> entities);
        /// <summary>
        /// Gets a table
        /// </summary>
        IQueryable<T> Table { get; }
        /// <summary>
        /// Gets a table with "no tracking" enabled(Ef feature) use it when you load records only for read-only operations
        /// </summary>
        IQueryable<T> TableNoTracking { get; }
    }
}
