using Library.BLL.ViewModels;

namespace Library.BLL.Services.Interfaces
{
    public interface IBookService
    {
        Task<List<BookVM>> GetAllBooksAsync();
        Task<List<BookVM>> GetBooksByUserIdAsync(Guid id);
    }
}
