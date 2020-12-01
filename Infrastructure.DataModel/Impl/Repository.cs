using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure.DataModel.Impl
{
    public class Repository<T> : IDisposable where T : class
    {
        private DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Get entity by identifier
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        public virtual T GetById(int id)
        {
            return this.Entities.Find(id);
        }

        /// <summary>
        /// Get all entity
        /// </summary>
        /// <returns></returns>
        public virtual List<T> GetAll()
        {
            return this.Entities.ToList();
        }

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual bool Insert(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.Entities.Add(entity);
            this._context.SaveChanges();
            return true;
        }



        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual bool Insert(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException("entities");

            foreach (var entity in entities)
                this.Entities.Add(entity);

            this._context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual bool Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            this.Entities.Update(entity);
            this._context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual bool Attach(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            this.Entities.Update(entity);
            return true;
        }

        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual bool Update(IEnumerable<T> entities)
        {

            if (entities == null)
                throw new ArgumentNullException("entities");
            foreach (var entity in entities)
                this.Entities.Update(entity);

            this._context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual bool Attach(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException("entities");
            foreach (var entity in entities)
                this.Entities.Update(entity);
            return true;
        }

        public virtual void Dispose()
        {
            this._context.Dispose();
        }
        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity">Entity</param>

        public virtual bool Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            this.Entities.Remove(entity);
            this._context.SaveChanges();
            return true;
        }

        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual bool Delete(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException("entities");

            foreach (var entity in entities)
                this.Entities.Remove(entity);

            this._context.SaveChanges();
            return true;
        }


        /// <summary>
        /// Get list by expression filter
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        protected virtual IQueryable<T> GetListByFilter(Expression<System.Func<T, bool>> expression)
        {
            return this.Entities.Where(expression);
        }


        /// <summary>
        /// Gets a table
        /// </summary>
        public virtual IQueryable<T> Table
        {
            get { return this.Entities; }
        }

        /// <summary>
        /// Gets a table with "no tracking" enabled .Use it only when you load record(s) only for read-only operations
        /// </summary>
        public virtual IQueryable<T> TableNoTracking
        {
            get { return this.Entities.AsNoTracking(); }
        }

        private DbSet<T> _entities;

        /// <summary>
        /// Entities
        /// </summary>
        protected virtual DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<T>();
                return _entities;
            }
        }

        /// <summary>
        /// Add entity,Not SaveChanges
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual T Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.Entities.Add(entity);
            return entity;
        }

        /// <summary>
        /// Add entites,Not SaveChanges
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual bool Add(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException("entities");

            foreach (var entity in entities)
                this.Entities.Add(entity);

            return true;
        }

        public virtual bool Detach(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            this._context.Entry(entity).State = EntityState.Detached;

            return true;
        }
        /// <summary>
        /// Context SaveChanges
        /// </summary>
        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}