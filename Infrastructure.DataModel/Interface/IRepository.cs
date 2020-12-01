using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.DataModel.Interface
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Get entity by identifier
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        T GetById(int id);

        /// <summary>
        /// Get all entity
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        bool Insert(T entity);

        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        bool Insert(IEnumerable<T> entities);

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity</param>
        bool Update(T entity);

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity</param>
        bool Attach(T entity);

        bool Attach(IEnumerable<T> entities);
        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        bool Update(IEnumerable<T> entities);


        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity">Entity</param>
        bool Delete(T entity);

        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities">Entities</param>
        bool Delete(IEnumerable<T> entities);

        /// <summary>
        /// Gets a table
        /// </summary>
        IQueryable<T> Table { get; }

        /// <summary>
        /// Gets a table with "no tracking" enabled (EF feature) Use it only when you load record(s) only for read-only operations
        /// </summary>
        IQueryable<T> TableNoTracking { get; }

        /// <summary>
        /// Add entity,Not SaveChanges
        /// </summary>
        /// <param name="entity">Entity</param>
        T Add(T entity);

        //T Change(T entity);

        /// <summary>
        /// Add entites,Not SaveChanges
        /// </summary>
        /// <param name="entities">Entities</param>
        bool Add(IEnumerable<T> entities);

        /// <summary>
        /// Context SaveChanges
        /// </summary>
        int Commit();

        bool Detach(T entity);
    }
}