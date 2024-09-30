using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 10.99M, Genre = "Classic" },
                new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 12.99M, Genre = "Classic" },
                new Book { Id = 3, Title = "1984", Author = "George Orwell", Price = 15.99M, Genre = "Dystopian" },
                new Book { Id = 4, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Price = 11.99M, Genre = "Classic" },
                new Book { Id = 5, Title = "Brave New World", Author = "Aldous Huxley", Price = 14.99M, Genre = "Science Fiction" }
            );
        }
    }
}
