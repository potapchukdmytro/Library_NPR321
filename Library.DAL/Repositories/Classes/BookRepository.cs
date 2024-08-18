using Library.DAL.Entities;
using Library.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories.Classes
{
    public class BookRepository : GenericRepository<BookEntity, Guid>, IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<BookEntity> Books => GetAll()
            .Include(b => b.Author)
            .Include(b => b.Users)
            .AsNoTracking();
    }
}
