using Library.BLL.ViewModels;

namespace Library.BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserVM>> GetAllUsersAsync();
    }
}
