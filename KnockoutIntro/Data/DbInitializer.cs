using System;
using System.Collections.Generic;
using System.Linq;
using KnockoutIntro.Models;

namespace KnockoutIntro.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BookContext context)
        { 
            context.Database.EnsureCreated();

            if (context.Books.Any())
            {
                return;
            }

            var author = new Author { FirstName = "Bob", LastName = "Test", Biography = "Testerino" };


            var books = new List<Book>
            {
                new Book{Title="Test1", Isbn="123456", Synopsis="Testerino", Description="Testerino", ImageUrl="Url test", author=author},
                new Book{Title="Test2", Isbn="123456", Synopsis="Testerino", Description="Testerino", ImageUrl="Url test", author=author},
                new Book{Title="Test3", Isbn="123456", Synopsis="Testerino", Description="Testerino", ImageUrl="Url test", author=author}

            };

            books.ForEach(b => context.Books.Add(b));

            context.SaveChanges();


            var author1 = new Author { FirstName = "Jim", LastName = "Test", Biography = "Testerino" };


            var books1 = new List<Book>
            {
                new Book{Title="Test1", Isbn="123456", Synopsis="Testerino", Description="Testerino", ImageUrl="Url test", author=author1},
                new Book{Title="Test2", Isbn="123456", Synopsis="Testerino", Description="Testerino", ImageUrl="Url test", author=author1},
                new Book{Title="Test3", Isbn="123456", Synopsis="Testerino", Description="Testerino", ImageUrl="Url test", author=author1}

            };

            books1.ForEach(b => context.Books.Add(b));

            context.SaveChanges();

            var author2 = new Author { FirstName = "Paul", LastName = "Test", Biography = "Testerino" };

            var books2 = new List<Book>
            {
                new Book{Title="Test1", Isbn="123456", Synopsis="Testerino", Description="Testerino", ImageUrl="Url test", author=author2},
                new Book{Title="Test2", Isbn="123456", Synopsis="Testerino", Description="Testerino", ImageUrl="Url test", author=author2},
                new Book{Title="Test3", Isbn="123456", Synopsis="Testerino", Description="Testerino", ImageUrl="Url test", author=author2}

            };

            books2.ForEach(b => context.Books.Add(b));

            context.SaveChanges();


        }
    }
}
