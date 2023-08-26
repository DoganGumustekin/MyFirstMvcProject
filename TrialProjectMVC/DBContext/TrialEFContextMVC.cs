using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using TrialProjectMVC.Models;

namespace TrialProjectMVC.DBContext
{
    public class TrialEFContextMVC : DbContext
    {
        public TrialEFContextMVC(DbContextOptions<TrialEFContextMVC> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhoneModel>().HasKey(p => p.PhoneId);

            modelBuilder.Entity<PhoneModel>().HasData(
                new PhoneModel { PhoneId = -1, Phone = "123123123", Address = "Istanbul" },
                new PhoneModel { PhoneId = -2, Phone = "3123123", Address = "Ankara" },
                new PhoneModel { PhoneId = -3, Phone = "23123123", Address = "Izmir" }
            );
        }

        public DbSet<PhoneModel> Phone { get; set; }

        
    }
}


//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

//namespace TrialProjectMVC.Migrations
//{
//    /// <inheritdoc />
//    public partial class SeedPhoneTable : Migration
//    {
//        /// <inheritdoc />
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.InsertData(
//                table: "Phone",
//                columns: new[] { "PhoneId", "Address", "Phone" },
//                values: new object[,]
//                {
//                    { 5, "Istanbul", "123123123" },
//                    { 6, "Ankara", "3123123" },
//                    { 7, "Izmir", "23123123" }
//                });
//        }

//        /// <inheritdoc />
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DeleteData(
//                table: "Phone",
//                keyColumn: "PhoneId",
//                keyValue: 5);

//            migrationBuilder.DeleteData(
//                table: "Phone",
//                keyColumn: "PhoneId",
//                keyValue: 6);

//            migrationBuilder.DeleteData(
//                table: "Phone",
//                keyColumn: "PhoneId",
//                keyValue: 7);
//        }
//    }
//}
