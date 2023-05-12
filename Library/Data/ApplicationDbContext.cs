using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Library.Models.Customer> Customer { get; set; } = default!;

        public DbSet<Library.Models.Book> Book { get; set; } = default!;
        public DbSet<BookConnection> BookConnections { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    Name = "Greger Gregersson",
                    Address = "Greger Vägen 10",
                    PostCode = "12345",
                    City = "Gregerstad",
                    PhoneNr = "1234567890"
                },
                new Customer
                {
                    CustomerId = 2,
                    Name = "Lena Lenasson",
                    Address = "Lena Vägen 99",
                    PostCode = "12346",
                    City = "Lenastad",
                    PhoneNr = "9876543210"

                },
                new Customer
                {
                    CustomerId = 3,
                    Name = "Sten Stensson",
                    Address = "Stenvägen 66",
                    PostCode = "23456",
                    City = "Stenstad",
                    PhoneNr = "19834563214"
                },
                new Customer
                {
                    CustomerId = 4,
                    Name = "Siv Sivsson",
                    Address = "Sivvägen 7",
                    PostCode = "98765",
                    City = "Sivstad",
                    PhoneNr = "23568971"



                });
                modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "Code like a Pro",
                    Author = " Reidar Nilsen",


                },
                new Book
                {
                    BookId = 2,
                    Title = "Fishing at night",
                    Author = "Albert Einstein"
                },
                new Book
                {
                    BookId = 3,
                    Title = "Murderer at the hospital",
                    Author = "Stina Stinasson"
                },
                new Book
                {
                    BookId = 4,
                    Title = "Face to face",
                    Author = "Tony Tonysson"
                },
                new Book
                {
                    BookId = 5,
                    Title = "From dusk till dawn",
                    Author = "My Mysson",
                },
                new Book
                {
                    BookId = 6,
                    Title = "Run away",
                    Author = "Mårten Mårtesson"
                });
            modelBuilder.Entity<BookConnection>().HasData(
                new BookConnection
                {
                    BookConnectionId = 1,
                    FK_CustomerId = 1,
                    FK_BookId = 1,
                    IsReturned = false,

                },
                new BookConnection
                {
                    BookConnectionId = 2,
                    FK_CustomerId = 1,
                    FK_BookId = 2,
                    IsReturned = false
                },
                new BookConnection
                {
                    BookConnectionId = 3,
                    FK_CustomerId = 2,
                    FK_BookId = 4,
                    IsReturned = true
                },
                new BookConnection
                {
                    BookConnectionId = 4,
                    FK_CustomerId = 3,
                    FK_BookId = 6,
                    IsReturned = true

                },
                new BookConnection
                {
                    BookConnectionId = 5,
                    FK_CustomerId = 4,
                    FK_BookId = 5,
                    IsReturned = false
                },
                new BookConnection
                {
                    BookConnectionId = 6,
                    FK_CustomerId = 4,
                    FK_BookId = 6,
                    IsReturned = false
                }) ;

        }  }
}
