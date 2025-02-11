﻿// <auto-generated />
using System;
using JediOrderApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JediOrderApi.Migrations
{
    [DbContext(typeof(JediOrderDbContext))]
    [Migration("20241025173642_Updated Primary Key On Tables")]
    partial class UpdatedPrimaryKeyOnTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JediOrderApi.Models.Domain.Images", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRetired")
                        .HasColumnType("bit");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SizeInBytes")
                        .HasColumnType("bigint");

                    b.Property<string>("UserCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("JediOrderApi.Models.Domain.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRetired")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2056),
                            DateModified = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2066),
                            Description = "A classic Italian pasta dish made with eggs, cheese, pancetta, and pepper.",
                            ImageUrl = "Spaghetti-image.jpg",
                            IsRetired = false,
                            Name = "Spaghetti Carbonara",
                            Price = 12.99m,
                            Type = "Dish",
                            UserCreated = "Admin",
                            UserModified = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2070),
                            DateModified = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2070),
                            Description = "Crisp romaine lettuce and croutons dressed with parmesan cheese, lemon juice, olive oil, and Worcestershire sauce.",
                            ImageUrl = "Caesar-image.jpg",
                            IsRetired = false,
                            Name = "Caesar Salad",
                            Price = 9.99m,
                            Type = "Dish",
                            UserCreated = "Admin",
                            UserModified = "Admin"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2073),
                            DateModified = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2073),
                            Description = "A refreshing soft drink with a unique taste that has been enjoyed for over a century.",
                            ImageUrl = "Coke-image.jpg",
                            IsRetired = false,
                            Name = "Coca Cola",
                            Price = 1.99m,
                            Type = "Drink",
                            UserCreated = "Admin",
                            UserModified = "Admin"
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2075),
                            DateModified = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2076),
                            Description = "Freshly squeezed orange juice, a perfect start to your day.",
                            ImageUrl = "Orange-image.jpg",
                            IsRetired = false,
                            Name = "Orange Juice",
                            Price = 2.49m,
                            Type = "Drink",
                            UserCreated = "Admin",
                            UserModified = "Admin"
                        });
                });

            modelBuilder.Entity("JediOrderApi.Models.Domain.Reviews", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRetired")
                        .HasColumnType("bit");

                    b.Property<int>("ProductsID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductsID");

                    b.ToTable("Review");

                    b.HasData(
                        new
                        {
                            Id = new Guid("733d4982-4564-47c0-9f0d-963dfb1d816b"),
                            Comment = "Hi, I had this meal and it was so delicious! Please keep serving it hot. I was very happy.",
                            DateCreated = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2189),
                            DateModified = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2189),
                            IsRetired = false,
                            ProductsID = 1,
                            Rating = 5,
                            ReviewTitle = "Delicious Meal With Extra Cheese",
                            UserCreated = "Noma",
                            UserId = 1,
                            UserModified = "Noma"
                        },
                        new
                        {
                            Id = new Guid("8e7b28e7-e242-4cf3-8d33-fdede23a429b"),
                            Comment = "The meal was cold and lacked flavor. The cheese was too much and overpowered everything. Not impressed.",
                            DateCreated = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2192),
                            DateModified = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2193),
                            IsRetired = false,
                            ProductsID = 1,
                            Rating = 2,
                            ReviewTitle = "Not so great",
                            UserCreated = "Bongani",
                            UserId = 2,
                            UserModified = "Bongani"
                        },
                        new
                        {
                            Id = new Guid("6e1c19c4-05c6-4501-9c86-2e1808cbf24c"),
                            Comment = "This drink was amazing! I loved the refreshing taste and the blend of flavors was perfect. Will definitely buy again.",
                            DateCreated = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2195),
                            DateModified = new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2196),
                            IsRetired = false,
                            ProductsID = 2,
                            Rating = 5,
                            ReviewTitle = "Fantastic Experience",
                            UserCreated = "Sihle",
                            UserId = 3,
                            UserModified = "Sihle"
                        });
                });

            modelBuilder.Entity("JediOrderApi.Models.Domain.Reviews", b =>
                {
                    b.HasOne("JediOrderApi.Models.Domain.Products", "Products")
                        .WithMany()
                        .HasForeignKey("ProductsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
