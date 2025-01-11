using BooksLibrary.Abstract;
using BooksLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var book = _bookService.GetBook(id);
            if (book == null)
            {
                return NotFound(book);
            }
            return Ok(book);
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            var books = _bookService.GetBooks();
            if (books == null)
                return NoContent();
            return Ok(books);
        }
    }
}