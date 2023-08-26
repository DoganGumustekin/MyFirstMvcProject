﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrialProjectMVC.DBContext;

#nullable disable

namespace TrialProjectMVC.Migrations
{
    [DbContext(typeof(TrialEFContextMVC))]
    partial class TrialEFContextMVCModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrialProjectMVC.Models.PhoneModel", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhoneId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneId");

                    b.ToTable("Phone");

                    b.HasData(
                        new
                        {
                            PhoneId = 1,
                            Address = "Istanbul",
                            Phone = "123123123"
                        },
                        new
                        {
                            PhoneId = 2,
                            Address = "Ankara",
                            Phone = "3123123"
                        },
                        new
                        {
                            PhoneId = 3,
                            Address = "Izmir",
                            Phone = "23123123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
