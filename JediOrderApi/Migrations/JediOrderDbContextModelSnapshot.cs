﻿// <auto-generated />
using System;
using JediOrderApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JediOrderApi.Migrations
{
    [DbContext(typeof(JediOrderDbContext))]
    partial class JediOrderDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JediOrderApi.Models.Domain.Images", b =>
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

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<long>("SizeInBytes")
                        .HasColumnType("bigint");

                    b.Property<string>("UserCreated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserModified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique()
                        .HasFilter("[ProductId] IS NOT NULL");

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
                            DateCreated = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9428),
                            DateModified = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9444),
                            Description = "A classic Italian pasta dish made with eggs, cheese, pancetta, and pepper.",
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
                            DateCreated = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9449),
                            DateModified = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9450),
                            Description = "Crisp romaine lettuce and croutons dressed with parmesan cheese, lemon juice, olive oil, and Worcestershire sauce.",
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
                            DateCreated = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9453),
                            DateModified = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9453),
                            Description = "A refreshing soft drink with a unique taste that has been enjoyed for over a century.",
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
                            DateCreated = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9456),
                            DateModified = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9457),
                            Description = "Freshly squeezed orange juice, a perfect start to your day.",
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                            Id = 1,
                            Comment = "Hi, I had this meal and it was so delicious! Please keep serving it hot. I was very happy.",
                            DateCreated = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9566),
                            DateModified = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9567),
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
                            Id = 2,
                            Comment = "The meal was cold and lacked flavor. The cheese was too much and overpowered everything. Not impressed.",
                            DateCreated = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9572),
                            DateModified = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9573),
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
                            Id = 3,
                            Comment = "This drink was amazing! I loved the refreshing taste and the blend of flavors was perfect. Will definitely buy again.",
                            DateCreated = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9576),
                            DateModified = new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9576),
                            IsRetired = false,
                            ProductsID = 2,
                            Rating = 5,
                            ReviewTitle = "Fantastic Experience",
                            UserCreated = "Sihle",
                            UserId = 3,
                            UserModified = "Sihle"
                        });
                });

            modelBuilder.Entity("JediOrderApi.Models.Domain.Images", b =>
                {
                    b.HasOne("JediOrderApi.Models.Domain.Products", "Product")
                        .WithOne("Image")
                        .HasForeignKey("JediOrderApi.Models.Domain.Images", "ProductId");

                    b.Navigation("Product");
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

            modelBuilder.Entity("JediOrderApi.Models.Domain.Products", b =>
                {
                    b.Navigation("Image");
                });
#pragma warning restore 612, 618
        }
    }
}
