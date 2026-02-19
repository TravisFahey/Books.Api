namespace Books.Api.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int AuthorId { get; set; }
        public int PublicationYear { get; set; }
        public GenreEnum Genre { get; set; }
        public Author? Author { get; set; }
    }
}
