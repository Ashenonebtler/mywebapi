namespace MyWebApi.Models
{
    public class BookDto
    {
        public string Title { get;  set;}= null!;
        public string Author { get; set; } = null!;
        public int YearPublished { get; set; }
    }
}