using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Author { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(1, 100)]
        public decimal Price { get; set; }
        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
    }
}