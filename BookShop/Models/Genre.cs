using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Genre")]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}