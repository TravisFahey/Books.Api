using Books.Api.Interfaces;
using Books.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Books.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetById")]
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

        [HttpGet("GetByAuthorId")]
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

        [HttpGet("GetByAuthorLastName")]
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

        [HttpGet("GetAll")]
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

        [HttpGet("GetByYear")]
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

        [HttpGet("GetByGenre")]
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
