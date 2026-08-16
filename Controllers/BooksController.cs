using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    
    public class BooksController : ControllerBase
    {
        static private List<BookDto> books = new List<BookDto>
        {
            new BookDto
            {
                Title = "The Amazing Spiderman",
                Author = "Amo Stanly",
                YearPublished = 2004
            },
            new BookDto
            {
                Title = "Arkham Knight",
                Author = "Gam3at Dc",
                YearPublished = 2001
            }
        };
        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return Ok(books);
        }   
    }
}
