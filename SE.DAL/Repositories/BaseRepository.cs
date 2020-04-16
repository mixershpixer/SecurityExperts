using Microsoft.EntityFrameworkCore;
using SE.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SE.DAL.Repositories
{/// <summary>
 /// Realization base repository.
 /// </summary>
 /// <typeparam name="TEntity">Object</typeparam>
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected SEContext Context;

        public BaseRepository(SEContext context)
        {
            Context = context;
        }
        protected DbSet<TEntity> DbSet
        {
            get
            {
                return Context.Set<TEntity>();
            }
        }

        /// <inheritdoc />
        public virtual async Task<TEntity> GetByPredicate(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.Where(predicate).FirstOrDefaultAsync();
        }

        /// <inheritdoc />
        public virtual async Task<IEnumerable<TEntity>> GetAll(
            Expression<Func<TEntity, bool>> predicate = null)
        {
            IQueryable<TEntity> query = DbSet;

            if (predicate != null)
                query = query.Where(predicate);

            return await query.ToListAsync();
        }

        /// <inheritdoc />
        public virtual async Task<TEntity> InsertAsync(TEntity entity)
        {
            var newEntity = await DbSet.AddAsync(entity);

            await Context.SaveChangesAsync();

            return newEntity.Entity;
        }

        /// <inheritdoc />
        public virtual void DeleteById(object id)
        {
            TEntity entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }

        /// <inheritdoc />
        public virtual void Delete(TEntity entityToDelete)
        {
            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
        }

        /// <inheritdoc />
        public virtual void Update(TEntity entityToUpdate)
        {
            DbSet.Attach(entityToUpdate);
            Context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}