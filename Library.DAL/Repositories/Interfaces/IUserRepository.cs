using Library.DAL.Entities;

namespace Library.DAL.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<UserEntity, Guid>
    {
        public IQueryable<UserEntity> Users { get; }
        Task<UserEntity?> GetByEmailAsync(string email);
        Task<UserEntity?> GetByUsername(string username);
        Task<UserEntity?> GetByIdIncludesAsync(Guid id);
    }
}
