using Books.Api.Interfaces;
using Books.Api.Models;

namespace Books.Api.Data
{
    public class BookRepository : IBookRepository
    {
        public List<Book> GetAll()
        {
            return new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "To Kill a Mockingbird",
                    AuthorId = 1,
                    PublicationYear = 1960,
                    Genre = GenreEnum.Fiction
                },
                new Book
                {
                    Id = 2,
                    Title = "Sapiens: A Brief History of Humankind",
                    AuthorId = 2,
                    PublicationYear = 2011,
                    Genre = GenreEnum.NonFiction
                },
                new Book
                {
                    Id = 3,
                    Title = "The Girl with the Dragon Tattoo",
                    AuthorId = 3,
                    PublicationYear = 2005,
                    Genre = GenreEnum.Mystery
                },
                new Book
                {
                    Id = 4,
                    Title = "The Hobbit",
                    AuthorId = 4,
                    PublicationYear = 1937,
                    Genre = GenreEnum.Fantasy
                },
                new Book
                {
                    Id = 5,
                    Title = "Dune",
                    AuthorId = 5,
                    PublicationYear = 1965,
                    Genre = GenreEnum.ScienceFiction
                },
                new Book
                {
                    Id = 6,
                    Title = "The Diary of a Young Girl",
                    AuthorId = 6,
                    PublicationYear = 1947,
                    Genre = GenreEnum.Biography
                },
                new Book
                {
                    Id = 7,
                    Title = "Pride and Prejudice",
                    AuthorId = 7,
                    PublicationYear = 1813,
                    Genre = GenreEnum.Romance
                },
                new Book
                {
                    Id = 8,
                    Title = "The Da Vinci Code",
                    AuthorId = 8,
                    PublicationYear = 2003,
                    Genre = GenreEnum.Thriller
                },
                new Book
                {
                    Id = 9,
                    Title = "Dracula",
                    AuthorId = 9,
                    PublicationYear = 1897,
                    Genre = GenreEnum.Horror
                },
                new Book
                {
                    Id = 10,
                    Title = "All the Light We Cannot See",
                    AuthorId = 10,
                    PublicationYear = 2014,
                    Genre = GenreEnum.Historical
                },
                new Book
                {
                    Id = 11,
                    Title = "The Catcher in the Rye",
                    AuthorId = 11,
                    PublicationYear = 1951,
                    Genre = GenreEnum.Fiction
                },
                new Book
                {
                    Id = 12,
                    Title = "Educated",
                    AuthorId = 12,
                    PublicationYear = 2018,
                    Genre = GenreEnum.NonFiction
                },
                new Book
                {
                    Id = 13,
                    Title = "Gone Girl",
                    AuthorId = 13,
                    PublicationYear = 2012,
                    Genre = GenreEnum.Mystery
                },
                new Book
                {
                    Id = 14,
                    Title = "Harry Potter and the Sorcerer's Stone",
                    AuthorId = 14,
                    PublicationYear = 1997,
                    Genre = GenreEnum.Fantasy
                },
                new Book
                {
                    Id = 15,
                    Title = "Ender's Game",
                    AuthorId = 15,
                    PublicationYear = 1985,
                    Genre = GenreEnum.ScienceFiction
                },
                new Book
                {
                    Id = 16,
                    Title = "Steve Jobs",
                    AuthorId = 16,
                    PublicationYear = 2011,
                    Genre = GenreEnum.Biography
                },
                new Book
                {
                    Id = 17,
                    Title = "Me Before You",
                    AuthorId = 17,
                    PublicationYear = 2012,
                    Genre = GenreEnum.Romance
                },
                new Book
                {
                    Id = 18,
                    Title = "The Silent Patient",
                    AuthorId = 18,
                    PublicationYear = 2019,
                    Genre = GenreEnum.Thriller
                },
                new Book
                {
                    Id = 19,
                    Title = "The Shining",
                    AuthorId = 19,
                    PublicationYear = 1977,
                    Genre = GenreEnum.Horror
                },
                new Book
                {
                    Id = 20,
                    Title = "The Book Thief",
                    AuthorId = 20,
                    PublicationYear = 2005,
                    Genre = GenreEnum.Historical
                }
            };
        }
    }
}
