namespace BookShop.Migrations
{
    using BookShop.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookShop.DAL.EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookShop.DAL.EFDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var genres = new List<Genre>
            {
                new Genre
                {
                    Name = "Drama",
                    Description = "Description of the Drama Genre"
                },
                new Genre
                {
                    Name = "Science Fiction",
                    Description = "Description of the Science Fiction Genre"
                },
                new Genre
                {
                    Name = "History",
                    Description = "Description of the History Genre"
                }
            };
            genres.ForEach(g => context.Genres.AddOrUpdate(p => p.Name, g));
            context.SaveChanges();

            var books = new List<Book>
            {
                new Book
                {
                    Title = "Romeo and Juliet",
                    Author = "William Shakespeare",
                    Price = 15,
                    GenreId = 1
                },
                new Book
                {
                    Title = "Macbeth",
                    Author = "William Shakespeare",
                    Price = 12,
                    GenreId = 1
                },
                new Book
                {
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Author = "Douglas Adams",
                    Price = 18,
                    GenreId = 2
                },
                new Book
                {
                    Title = "2001: A Space Odyssey",
                    Author = "Arthur C. Clarke",
                    Price = 20,
                    GenreId = 2
                },
                new Book
                {
                    Title = "Dune",
                    Author = "Frank Herbert",
                    Price = 8,
                    GenreId = 2
                },
                new Book
                {
                    Title = "The Decline and Fall of the Roman Empire",
                    Author = "Edward Gibbon",
                    Price = 17,
                    GenreId = 3
                }
            };
            books.ForEach(b => context.Books.AddOrUpdate(p => p.Title, b));
            context.SaveChanges();
        }
    }
}
