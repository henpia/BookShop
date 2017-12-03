using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookShop.DAL
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base("BookShopConnection") { }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}