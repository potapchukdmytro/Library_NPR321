using Library.BLL.Services.Interfaces;
using Library.BLL.ViewModels;
using Library.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Library.BLL.Services.Classes
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserVM>> GetAllUsersAsync()
        {
            var entities = await _userRepository.Users.ToListAsync();

            var models = entities.Select(e => new UserVM
            {
                Id = e.Id,
                Email = e.Email,
                FirstName = e.FirstName,
                Image = e.Image,
                LastName = e.LastName,
                Password = e.Password,
                PhoneNumber = e.PhoneNumber,
                Role = e.Role.Name,
                UserName = e.UserName
            }).ToList();

            return models;
        }
    }
}
