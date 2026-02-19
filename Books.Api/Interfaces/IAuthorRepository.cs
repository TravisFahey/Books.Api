using Books.Api.Models;

namespace Books.Api.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();
    }
}
