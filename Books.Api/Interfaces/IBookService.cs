using Books.Api.Data;
using Books.Api.Models;

namespace Books.Api.Interfaces
{
    public interface IBookService
    {
        Book GetById(int id);
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetByAuthorId(int authorId);
        IEnumerable<Book> GetByAuthorLastName(string lastName);
        IEnumerable<Book> GetByYear(int year);
        IEnumerable<Book> GetByGenre(GenreEnum genre);
    }
}
