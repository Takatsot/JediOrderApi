using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JediOrderApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductsID", "DateCreated", "DateModified", "Description", "ImageUrl", "Name", "Price", "Type", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7516), "A classic Italian pasta dish made with eggs, cheese, pancetta, and pepper.", "Spaghetti-image.jpg", "Spaghetti Carbonara", 12.99m, "Dish", "Admin", "Admin" },
                    { 2, new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7519), new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7520), "Crisp romaine lettuce and croutons dressed with parmesan cheese, lemon juice, olive oil, and Worcestershire sauce.", "Caesar-image.jpg", "Caesar Salad", 9.99m, "Dish", "Admin", "Admin" },
                    { 3, new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7522), new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7523), "A refreshing soft drink with a unique taste that has been enjoyed for over a century.", "Coke-image.jpg", "Coca Cola", 1.99m, "Drink", "Admin", "Admin" },
                    { 4, new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7525), new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7526), "Freshly squeezed orange juice, a perfect start to your day.", "Orange-image.jpg", "Orange Juice", 2.49m, "Drink", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewsID", "Comment", "DateCreated", "DateModified", "ProductsID", "Rating", "ReviewTitle", "UserCreated", "UserId", "UserModified" },
                values: new object[,]
                {
                    { new Guid("13fbda39-8e1d-4b2d-b7c2-c062cb4fd46b"), "Hi, I had this meal and it was so delicious! Please keep serving it hot. I was very happy.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, "Delicious Meal With Extra Cheese", "Noma", 1, "Noma" },
                    { new Guid("2217911a-6af8-4372-a9ee-98dc60028df6"), "The meal was cold and lacked flavor. The cheese was too much and overpowered everything. Not impressed.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "Not so great", "Bongani", 2, "Bongani" },
                    { new Guid("5148c3e7-0a54-43a2-a7ee-7fa6e5415fa8"), "This drink was amazing! I loved the refreshing taste and the blend of flavors was perfect. Will definitely buy again.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5, "Fantastic Experience", "Sihle", 3, "Sihle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductsID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductsID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewsID",
                keyValue: new Guid("13fbda39-8e1d-4b2d-b7c2-c062cb4fd46b"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewsID",
                keyValue: new Guid("2217911a-6af8-4372-a9ee-98dc60028df6"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewsID",
                keyValue: new Guid("5148c3e7-0a54-43a2-a7ee-7fa6e5415fa8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductsID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductsID",
                keyValue: 2);
        }
    }
}
