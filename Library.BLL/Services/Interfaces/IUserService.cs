using Library.BLL.ViewModels;

namespace Library.BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserVM>> GetAllUsersAsync();
        Task DeleteBookByUserAsync(Guid userId, Guid bookId);
        Task AddBooksForUserAsync(Guid userId, List<Guid> booksId);
        Task<UserVM?> GetUserByIdAsync(string id);
        Task<List<BookVM>> GetBooksByUserIdAsync(Guid id);

    }
}
