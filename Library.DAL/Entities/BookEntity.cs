namespace Library.DAL.Entities
{
    public class BookEntity : BaseEntity<Guid>
    {
        public required string Title { get; set; }
        public required string Language { get; set; }
        public required string Category { get; set; }
        public int PageCount { get; set; }
        public short Year { get; set; }
        public string? Publisher { get; set; }

        public Guid AuthorId { get; set; }
        public AuthorEntity? Author { get; set; }

        public List<UserEntity> Users { get; set; } = new();
    }
}
