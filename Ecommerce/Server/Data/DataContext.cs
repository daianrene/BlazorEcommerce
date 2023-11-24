using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Title Test",
                    Description = "Description test",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Rolex_Submariner_Professional.JPG/1280px-Rolex_Submariner_Professional.JPG",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Watch2",
                    Description = "Description2",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/6/67/RolexDaytona.jpg",
                    Price = 3.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Watch3",
                    Description = "Description3",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f9/Spring-cover_pocket_clock3_open_clockface2.jpg/1200px-Spring-cover_pocket_clock3_open_clockface2.jpg",
                    Price = 4.99m
                }
            );
        }
        public DbSet<Product> Products { get; set; }

    }
}
