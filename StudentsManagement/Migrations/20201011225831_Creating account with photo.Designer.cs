﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsManagement.Models;

namespace StudentsManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201011225831_Creating account with photo")]
    partial class Creatingaccountwithphoto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("StudentsManagement.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("Faculty");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PicturePath");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Class = "IIIA",
                            Email = "woj.tek@gmail.com",
                            Faculty = 1,
                            Name = "Wojciech"
                        },
                        new
                        {
                            Id = 2,
                            Class = "IIIB",
                            Email = "ma.rek@gmail.com",
                            Faculty = 4,
                            Name = "Marek"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
