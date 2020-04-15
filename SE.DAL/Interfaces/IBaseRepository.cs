using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SE.DAL.Interfaces
{
    /// <summary>
    /// Interface for base repository.
    /// </summary>
    /// <typeparam name="TEntity">Object</typeparam>
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Read object from db.
        /// </summary>
        /// <returns>Object</returns>
        Task<TEntity> GetByPredicate(Expression<Func<TEntity, bool>> predicate = null);

        /// <summary>
        /// Read objects from db.
        /// </summary>
        /// <returns>Objects</returns>
        Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate = null);

        /// <summary>
        /// Create new object in db.
        /// </summary>
        /// <param name="entity">Object</param>
        /// <returns>Object</returns>
        Task<TEntity> InsertAsync(TEntity entity);

        /// <summary>
        /// Delete object in db by id.
        /// </summary>
        /// <param name="id">Object.</param>
        void DeleteById(object id);

        /// <summary>
        /// Delete object in db.
        /// </summary>
        /// <param name="entityToDelete">Object.</param>
        void Delete(TEntity entityToDelete);

        /// <summary>
        /// Update object in db.
        /// </summary>
        /// <param name="entityToUpdate">Object</param>
        void Update(TEntity entityToUpdate);
    }
}
