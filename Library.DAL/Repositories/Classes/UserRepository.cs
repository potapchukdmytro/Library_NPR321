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

        private IQueryable<UserEntity> GetUsersWithIncludes()
        {
            return GetAll()
                .Include(u => u.Role)
                .Include(u => u.Books)
                .ThenInclude(b => b.Author);
        }

        public IQueryable<UserEntity> Users => GetUsersWithIncludes().AsNoTracking();

        public async Task<UserEntity?> GetByEmailAsync(string email)
        {
            return await Users
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<UserEntity?> GetByIdIncludesAsync(Guid id)
        {
            return await GetUsersWithIncludes()
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<UserEntity?> GetByUsername(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);
        }
    }
}
