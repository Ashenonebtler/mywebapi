using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
         private static readonly List<Book> Books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "The Amazing Spiderman",
                Author = "Amo Stanly",
                YearPublished = 2004
            },
            new Book
            {
                Id = 2,
                Title = "Arkham Knight",
                Author = "Gam3at Dc",
                YearPublished = 2001
            },
            new Book
            {
                Id = 3,
                Title = "The Hobbit",
                Author = "J.R.R. Tolkien",
                YearPublished = 1937
            },
            new Book
            {
                Id = 4,
                Title = "Dune",
                Author = "Frank Herbert",
                YearPublished = 1965
            },
            new Book
            {
                Id = 5,
                Title = "1984",
                Author = "George Orwell",
                YearPublished = 1949
            },
            new Book
            {
                Id = 6,
                Title = "The Hitchhiker's Guide to the Galaxy",
                Author = "Douglas Adams",
                YearPublished = 1979
            }
        };
        
        [HttpGet("{id}")]
        public ActionResult<BookDto> GetBookById(int id)
        {
            var book = Books.FirstOrDefault((x) => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                var bookById = new BookDto()
                {
                    Title = book.Title,
                    Author = book.Author,
                    YearPublished = book.YearPublished,
                };
                return Ok(bookById);
            }
        }
        
    }
}