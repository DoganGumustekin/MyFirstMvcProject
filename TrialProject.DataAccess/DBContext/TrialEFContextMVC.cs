using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using TrialProject.Models;

namespace TrialProject.DataAccess.DBContext
{
    public class TrialEFContextMVC : DbContext
    {
        public TrialEFContextMVC(DbContextOptions<TrialEFContextMVC> options) : base(options)
        {
        }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhoneModel>().HasKey(p => p.PhoneId);
            modelBuilder.Entity<ProductModel>().HasKey(p => p.ProductID);

            modelBuilder.Entity<PhoneModel>().HasData(
                new PhoneModel { PhoneId = -1, Phone = "123123123", Address = "Istanbul" },
                new PhoneModel { PhoneId = -2, Phone = "3123123", Address = "Ankara" },
                new PhoneModel { PhoneId = -3, Phone = "23123123", Address = "Izmir" }
            );

            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel
                {
                    ProductID = 1,
                    Title = "Fortune of Time",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "SWD9999001",
                    Author = "Billy Spark",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                },
                new ProductModel
                {
                    ProductID = 2,
                    Title = "Dark Skies",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "CAW777777701",
                    Author = "Nancy Hoover",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                },
                new ProductModel
                {
                    ProductID = 3,
                    Title = "Vanish in the Sunset",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "RITO5555501",
                    Author = "Julian Button",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                },
                new ProductModel
                {
                    ProductID = 4,
                    Title = "Cotton Candy",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "WS3333333301",
                    Author = "Abby Muscles",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                },
                new ProductModel
                {
                    ProductID = 5,
                    Title = "Rock in the Ocean",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "SOTJ1111111101",
                    Author = "Ron Parker",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                },
                new ProductModel
                {
                    ProductID = 6,
                    Title = "Leaves and Wonders",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ISBN = "FOT000000001",
                    Author = "Laura Phantom",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                }
            );
        }
        public DbSet<PhoneModel> Phone { get; set; }
        public DbSet<ProductModel> Product { get; set; }


    }
}