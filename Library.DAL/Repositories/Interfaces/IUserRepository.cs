using Library.DAL.Entities;

namespace Library.DAL.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<UserEntity, Guid>
    {
        public IQueryable<UserEntity> Users { get; }
        public Task<UserEntity> GetByEmailAsync(string email);
    }
}
