using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Domain.Entities;
using SimpleBookCatalog.Domain.Enums;

namespace SimpleBookCatalog.Infrastructure.Context
{
    public class SimpleBookCatalogDbContext : DbContext
    {
        public SimpleBookCatalogDbContext(DbContextOptions<SimpleBookCatalogDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "The Science of Everything",
                    Author = "Jane Appleton",
                    PublicationDate = new DateTime(2020, 5, 12),
                    Category = Catagory.Science
                },
                new Book
                {
                    Id = 2,
                    Title = "Modern Fitness Guide",
                    Author = "John Fit",
                    PublicationDate = new DateTime(2022, 1, 20),
                    Category = Catagory.Fitness
                },
                new Book
                {
                    Id = 3,
                    Title = "Tech Innovations",
                    Author = "Sara Tech",
                    PublicationDate = new DateTime(2021, 8, 15),
                    Category = Catagory.Technology
                },
                new Book
                {
                    Id = 4,
                    Title = "World Travel Atlas",
                    Author = "Marco Polo",
                    PublicationDate = new DateTime(2019, 11, 5),
                    Category = Catagory.Travel
                }
            );
        }
    }
}
