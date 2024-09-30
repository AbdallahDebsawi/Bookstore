using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        [StringLength(50)]
        public string Author { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(100, 1000, ErrorMessage = "Price must be between 100 and 1000")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        [StringLength(30)]
        public string Genre { get; set; }
    }
}
