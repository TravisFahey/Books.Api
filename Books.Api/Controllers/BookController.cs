using Books.Api.Interfaces;
using Books.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Books.Api.Controllers
{
    /// <summary>
    /// Controller for managing book-related operations.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookController"/> class.
        /// </summary>
        /// <param name="bookService">The service for managing books.</param>
        public BookController(IBookService bookService) => _bookService = bookService;

        /// <summary>
        /// Retrieves a book by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the book.</param>
        /// <returns>A book if found; otherwise, a 404 Not Found response.</returns>
        [HttpGet("GetById")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id)
        {
            try 
            {
                var book = _bookService.GetById(id);
                return Ok(book);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves books by the author's unique identifier.
        /// </summary>
        /// <param name="authorId">The unique identifier of the author.</param>
        /// <returns>A list of books if found; otherwise, a 404 Not Found response.</returns>
        [HttpGet("GetByAuthorId")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<Book>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetByAuthorId(int authorId)
        {
            try
            {
                var books = _bookService.GetByAuthorId(authorId);
                return Ok(books);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves books by the author's last name.
        /// </summary>
        /// <param name="lastName">The last name of the author.</param>
        /// <returns>A list of books if found; otherwise, a 404 Not Found response.</returns>
        [HttpGet("GetByAuthorLastName")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<Book>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetByAuthorLastName(string lastName)
        {
            try 
            {
                var books = _bookService.GetByAuthorLastName(lastName);
                return Ok(books);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves all books.
        /// </summary>
        /// <returns>A list of all books; otherwise, a 500 Internal Server Error response.</returns>
        [HttpGet("GetAll")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<Book>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAll()
        {
            try 
            {
                var books = _bookService.GetAll();
                return Ok(books);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while retrieving books: {ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves books published in a specific year.
        /// </summary>
        /// <param name="year">The year of publication.</param>
        /// <returns>A list of books if found; otherwise, a 500 Internal Server Error response.</returns>
        [HttpGet("GetByYear")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<Book>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetByYear(int year)
        {
            try 
            {
                var books = _bookService.GetByYear(year);
                return Ok(books);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while retrieving books by year: {ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves books by genre.
        /// </summary>
        /// <param name="genre">The genre of the books.</param>
        /// <returns>A list of books if found; otherwise, a 500 Internal Server Error response.</returns>
        [HttpGet("GetByGenre")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<Book>), StatusCodes.Status200OK)] 
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] 
        public IActionResult GetByGenre(GenreEnum genre)
        {
            try
            {
                var books = _bookService.GetByGenre(genre);
                return Ok(books);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while retrieving books by genre: {ex.Message}");
            }
        }
    }
}
