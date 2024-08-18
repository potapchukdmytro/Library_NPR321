using AutoMapper;
using Library.BLL.Services.Interfaces;
using Library.BLL.ViewModels;
using Library.DAL.Repositories.Interfaces;

namespace Library.BLL.Services.Classes
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public AuthService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse> SignInAsync(SignInVM model)
        {
            var entity = await _userRepository.GetByEmailAsync(model.Email);

            if (entity == null)
            {
                return new ServiceResponse
                {
                    Success = false,
                    Message = "Не вірна електорнна пошта",
                    Payload = null
                };
            }

            if (entity.Password != model.Password)
            {
                return new ServiceResponse
                {
                    Success = false,
                    Message = "Не вірний пароль",
                    Payload = null
                };
            }

            var userModel = _mapper.Map<UserVM>(entity);

            return new ServiceResponse
            {
                Success = true,
                Message = "Успішний вхід",
                Payload = userModel
            };
        }
    }
}
