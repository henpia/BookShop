namespace BookShop.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
    }
}