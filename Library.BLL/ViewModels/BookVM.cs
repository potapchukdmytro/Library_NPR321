namespace Library.BLL.ViewModels
{
    public class BookVM
    {
        public required string Id { get; set; }
        public required string Title { get; set; }
        public required string Language { get; set; }
        public required string Category { get; set; }
        public int PageCount { get; set; }
        public short Year { get; set; }
        public string? Publisher { get; set; }
        public required string Author { get; set; }
    }
}
