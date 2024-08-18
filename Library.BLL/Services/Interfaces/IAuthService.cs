using Library.BLL.ViewModels;

namespace Library.BLL.Services.Interfaces
{
    public interface IAuthService
    {
        Task<ServiceResponse> SignInAsync(SignInVM model);
    }
}
