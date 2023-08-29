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

            modelBuilder.Entity<PhoneModel>().HasData(
                new PhoneModel { PhoneId = -1, Phone = "123123123", Address = "Istanbul" },
                new PhoneModel { PhoneId = -2, Phone = "3123123", Address = "Ankara" },
                new PhoneModel { PhoneId = -3, Phone = "23123123", Address = "Izmir" }
            );
        }

        public DbSet<PhoneModel> Phone { get; set; }

        
    }
}