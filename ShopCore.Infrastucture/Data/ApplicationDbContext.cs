using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopCore.Core.Entities;
namespace ShopCore.Infrastucture.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToTable("Countries");
            modelBuilder.Entity<Category>().ToTable("Categories");
            //---------------------------------------------------------------------SeedData
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Mobile",
                    CategoryDescription = "Mobile Phones"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Laptop",
                    CategoryDescription = "Laptop Computers"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = Guid.Parse("03E83F82-E9E6-49BE-BB7E-769DEE327FA5"),
                    ProductName = "iPhone 17",
                    ProductDescription = "Apple Smartphone",
                    ProductPrice = 1000,
                    StockQuantity = 10,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = Guid.Parse("4C238277-1CE8-4023-8E94-654A5AC72732"),
                    ProductName = "Samsung S25",
                    ProductDescription = "Samsung Smartphone",
                    ProductPrice = 800,
                    StockQuantity = 15,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = Guid.Parse("A441E10E-DCB5-4D83-8A1B-70E5A5C44B95"),
                    ProductName = "ASUS TUF",
                    ProductDescription = "Gaming Laptop",
                    ProductPrice = 1500,
                    StockQuantity = 5,
                    CategoryId = 2
                }
            );

        }

            
    }
}
