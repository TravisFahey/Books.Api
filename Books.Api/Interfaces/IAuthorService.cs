using Books.Api.Models;

namespace Books.Api.Interfaces
{
    public interface IAuthorService
    {
        Author GetById(int id);
        Author GetByLastName(string lastName);
    }
}
