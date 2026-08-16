using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        static private List<Book> books = new List<Book>
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
            }
        };

        [HttpGet("{id}")]
        public ActionResult<List<BookDto>> GetBookById(int id)
        {
            var book = books.FirstOrDefault((x) => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                var bookbid = new BookDto()
                {
                    Title = book.Title,
                    Author = book.Author,
                    YearPublished = book.YearPublished,
                };
                return Ok(bookbid);
            }
        }
        
    }
}