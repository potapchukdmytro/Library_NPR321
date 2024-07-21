using System.ComponentModel.DataAnnotations.Schema;

namespace Library.DAL.Entities
{
    public class UserEntity : BaseEntity<Guid>
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Image { get; set; }

        // Navigation properties
        public Guid RoleId { get; set; }
        public RoleEntity? Role { get; set; }

        public List<BookEntity> Books { get; set; } = new();
    }
}
