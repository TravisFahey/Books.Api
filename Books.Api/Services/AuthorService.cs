using Books.Api.Interfaces;
using Books.Api.Models;

namespace Books.Api.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public Author GetById(int id)
            => _authorRepository.GetAll().Where(x => x.Id == id).First() ?? throw new ArgumentException($"Could not find author with ID: {id}", nameof(id));

        public Author GetByLastName(string lastName)
            => _authorRepository.GetAll().Where(x => x.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)).First() ?? throw new ArgumentException($"Could not find author with last name: {lastName}", nameof(lastName));
    }
}
