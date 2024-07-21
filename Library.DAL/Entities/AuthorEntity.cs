namespace Library.DAL.Entities
{
    public class AuthorEntity : BaseEntity<Guid>
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int BirthYear { get; set; }
        public virtual IEnumerable<BookEntity> Books { get; set; } = new List<BookEntity>();
    }
}
