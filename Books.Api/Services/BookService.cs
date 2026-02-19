using Books.Api.Interfaces;
using Books.Api.Models;

namespace Books.Api.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorService _authorService;
        public BookService(IBookRepository repository, IAuthorService authorService)
        {
            _bookRepository = repository;
            _authorService = authorService;
        }

        public Book GetById(int id)
        {
            var book = _bookRepository.GetAll().Where(x => x.Id == id).First() ?? throw new ArgumentException($"Could not find book with ID: {id}", nameof(id));
            book.Author = _authorService.GetById(book.AuthorId);

            return book;
        }

        public IEnumerable<Book> GetAll()
            => _bookRepository.GetAll();

        public IEnumerable<Book> GetByAuthorId(int authorId)
            => _bookRepository.GetAll().Where(x => x.AuthorId == authorId);

        public IEnumerable<Book> GetByAuthorLastName(string lastName)
        {
            var author = _authorService.GetByLastName(lastName);
            
            if (author == null)
                throw new ArgumentException($"Could not find author with last name: {lastName}", nameof(lastName));

            return _bookRepository.GetAll().Where(x => x.AuthorId == author.Id);
        }

        public IEnumerable<Book> GetByYear(int year)
            => _bookRepository.GetAll().Where(x => x.PublicationYear == year);

        public IEnumerable<Book> GetByGenre(GenreEnum genre)
            => _bookRepository.GetAll().Where(x => x.Genre == genre);
    }
}
