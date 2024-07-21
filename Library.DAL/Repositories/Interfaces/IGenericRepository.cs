using Library.DAL.Entities;

namespace Library.DAL.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity, TId>
        where TEntity : class, IBaseEntity<TId>
        where TId : notnull
    {
        Task<bool> CreateAsync(TEntity entity);
        Task<bool> DeleteAsync(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);
        Task<TEntity?> GetByIdAsync(TId id);
        IQueryable<TEntity> GetAll();
    }
}
