using Library.DAL.Entities;
using Library.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories.Classes
{
    public class GenericRepository<TEntity, TId> : IGenericRepository<TEntity, TId>
        where TEntity : class, IBaseEntity<TId>
        where TId : notnull
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(TEntity entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            entity.UpdatedDate = DateTime.UtcNow;
            await _context.AddAsync(entity);
            var res = await _context.SaveChangesAsync();
            return res != 0;
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            _context.Remove(entity);
            var res = await _context.SaveChangesAsync();
            return res != 0;
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            entity.UpdatedDate = DateTime.UtcNow;
            _context.Update(entity);
            var res = await _context.SaveChangesAsync();
            return res != 0;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsQueryable();
        }

        public Task<TEntity?> GetByIdAsync(TId id)
        {
            return _context.Set<TEntity>().FirstOrDefaultAsync(e => e.Id.Equals(id));
        }
    }
}
