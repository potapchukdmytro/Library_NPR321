using AutoMapper;
using Library.BLL.Services.Interfaces;
using Library.BLL.ViewModels;
using Library.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Services.Classes
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<BookVM>> GetAllBooksAsync()
        {
            var entities = await _bookRepository.Books.ToListAsync();

            var models = _mapper.Map<List<BookVM>>(entities);

            return models;
        }

        public async Task<List<BookVM>> GetBooksByUserIdAsync(Guid id)
        {
            var entities = await _bookRepository.Books.Where(b => b.Users.Any(u => u.Id == id)).ToListAsync();

            var models = _mapper.Map<List<BookVM>>(entities);

            return models;
        }
    }
}
