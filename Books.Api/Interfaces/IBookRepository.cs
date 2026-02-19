using Books.Api.Models;

namespace Books.Api.Interfaces
{
    public interface 
        IBookRepository
    {
        List<Book> GetAll();
    }
}
