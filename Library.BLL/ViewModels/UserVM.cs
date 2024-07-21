using Library.DAL.Entities;

namespace Library.BLL.ViewModels
{
    public class UserVM
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }
        public string Role { get; set; }
    }
}
