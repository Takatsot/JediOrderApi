using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JediOrderApi.Migrations
{
    /// <inheritdoc />
    public partial class Updatedonthemigrationaddedseedsback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "IsRetired", "Name", "Price", "Type", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3811), new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3824), "A classic Italian pasta dish made with eggs, cheese, pancetta, and pepper.", false, "Spaghetti Carbonara", 12.99m, "Dish", "Admin", "Admin" },
                    { 2, new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3828), new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3829), "Crisp romaine lettuce and croutons dressed with parmesan cheese, lemon juice, olive oil, and Worcestershire sauce.", false, "Caesar Salad", 9.99m, "Dish", "Admin", "Admin" },
                    { 3, new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3831), new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3832), "A refreshing soft drink with a unique taste that has been enjoyed for over a century.", false, "Coca Cola", 1.99m, "Drink", "Admin", "Admin" },
                    { 4, new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3835), new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3835), "Freshly squeezed orange juice, a perfect start to your day.", false, "Orange Juice", 2.49m, "Drink", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "DateCreated", "DateModified", "IsRetired", "ProductsID", "Rating", "ReviewTitle", "UserCreated", "UserId", "UserModified" },
                values: new object[,]
                {
                    { new Guid("75957251-de94-4bdd-b8b5-edbbcb3a9b6e"), "Hi, I had this meal and it was so delicious! Please keep serving it hot. I was very happy.", new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(4068), new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(4069), false, 1, 5, "Delicious Meal With Extra Cheese", "Noma", 1, "Noma" },
                    { new Guid("76e264b7-1e45-4c05-b055-5bda670edce5"), "The meal was cold and lacked flavor. The cheese was too much and overpowered everything. Not impressed.", new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(4074), new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(4074), false, 1, 2, "Not so great", "Bongani", 2, "Bongani" },
                    { new Guid("eee31e32-5e9d-406e-922b-0dccf914469a"), "This drink was amazing! I loved the refreshing taste and the blend of flavors was perfect. Will definitely buy again.", new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(4077), new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(4078), false, 2, 5, "Fantastic Experience", "Sihle", 3, "Sihle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("75957251-de94-4bdd-b8b5-edbbcb3a9b6e"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("76e264b7-1e45-4c05-b055-5bda670edce5"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("eee31e32-5e9d-406e-922b-0dccf914469a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
