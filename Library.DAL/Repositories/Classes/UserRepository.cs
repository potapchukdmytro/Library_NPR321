using Library.DAL.Entities;
using Library.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories.Classes
{
    public class UserRepository : GenericRepository<UserEntity, Guid>, IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<UserEntity> Users => GetAll()
            .Include(u => u.Role)
            .Include(u => u.Books)
            .AsNoTracking();

        public Task<UserEntity> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
