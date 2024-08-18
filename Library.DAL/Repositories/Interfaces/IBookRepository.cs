using Library.DAL.Entities;

namespace Library.DAL.Repositories.Interfaces
{
    public interface IBookRepository : IGenericRepository<BookEntity, Guid>
    {
        public IQueryable<BookEntity> Books { get; }
    }
}
