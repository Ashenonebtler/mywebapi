using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    
    public class BooksController : ControllerBase
    {
        static private List<Book> books = new List<Book>
        {
            new Book
            {
                ID = 1,
                Title = "The Amazing Spiderman",
                Author = "Amo Stanly",
                YearPublished = 2004
            },
            new Book
            {
                ID = 2,
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
