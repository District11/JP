using JP.Data.Models;
using JP.Services;
using JustProject.RequestModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace JustProject.Controllers
{
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly ILogger<BooksController> _logger;
        private readonly IBookService _bookService;

        public BooksController(ILogger<BooksController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet("/api/books")]
        public ActionResult GetBooks()
        {
           var books = _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("/api/books/{id}")]
        public ActionResult GetBook(int id)
        {
            var book = _bookService.GetBook(id);
            return Ok(book);
        }

        [HttpPost("/api/books")]
        public ActionResult CreateBook([FromBody] NewBookRequest bookRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model state note valid");
            }

            var now = DateTime.UtcNow;

            var book = new Book
            {
                CreatedOn = now,
                Updatedon = now,
                Title = bookRequest.Title,
                Author = bookRequest.Author
            };
                _bookService.AddBook(book);

            return Ok($"Book created: {book.Title}");
        }

        [HttpDelete("/api/books/{id}")]
        public ActionResult DeleteBook(int id)
        {
            _bookService.DeleteBook(id);
            return Ok($"Book deleted with ID: {id}");
        }
    }
}
