using AutoMapper;
using Library.BLL.Services.Interfaces;
using Library.BLL.ViewModels;
using Library.DAL;
using Library.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Library.BLL.Services.Classes
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IBookRepository _bookRepository;
        private AppDbContext _context;
        private IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper, IBookRepository bookRepository, AppDbContext context)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _bookRepository = bookRepository;
            _context = context;
        }

        public async Task AddBooksForUserAsync(Guid userId, List<Guid> booksId)
        {
            var user = await _userRepository.GetByIdIncludesAsync(userId);

            if (user != null)
            {
                foreach (var bookId in booksId)
                {
                    var existingBook = _context.Books.Local.FirstOrDefault(b => b.Id == bookId);

                    if (existingBook == null)
                    {
                        var book = await _bookRepository.Books.FirstOrDefaultAsync(b => b.Id == bookId);

                        if (book != null)
                        {
                            user.Books.Add(book);
                        }
                    }
                    else
                    {
                        if (!user.Books.Contains(existingBook))
                        {
                            user.Books.Add(existingBook);
                        }
                    }
                }

                _context.Attach(user);
                await _userRepository.UpdateAsync(user);
            }
        }

        public async Task DeleteBookByUserAsync(Guid userId, Guid bookId)
        {
            var user = await _userRepository.GetByIdIncludesAsync(userId);

            if (user != null)
            {
                user.Books = user.Books.Where(b => b.Id != bookId).ToList();

                await _userRepository.UpdateAsync(user);
            }
        }

        public async Task<List<BookVM>> GetBooksByUserIdAsync(Guid id)
        {
            var user = await _userRepository.Users.FirstOrDefaultAsync(u => u.Id == id);

            var booksModel = _mapper.Map<List<BookVM>>(user.Books);

            return booksModel;
        }

        public async Task<List<UserVM>> GetAllUsersAsync()
        {
            var entities = await _userRepository.Users.ToListAsync();

            //var models = entities.Select(e => new UserVM
            //{
            //    Id = e.Id.ToString(),
            //    Email = e.Email,
            //    FirstName = e.FirstName,
            //    Image = e.Image,
            //    LastName = e.LastName,
            //    PhoneNumber = e.PhoneNumber,
            //    Role = e.Role?.Name ?? "unknown",
            //    UserName = e.UserName
            //}).ToList();

            var models = _mapper.Map<List<UserVM>>(entities);

            return models;
        }

        public async Task<UserVM?> GetUserByIdAsync(string id)
        {
            var entity = await _userRepository
                .Users
                .FirstOrDefaultAsync(u => u.Id == Guid.Parse(id));

            if (entity == null)
            {
                return null;
            }

            var model = _mapper.Map<UserVM>(entity);

            return model;
        }
    }
}
