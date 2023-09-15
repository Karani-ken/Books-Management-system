using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class BookDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
       
        public List<Author> Authors { get; set; } = new List<Author>();
    }
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string AuthorName { get; set; } = string.Empty;
    }
}
