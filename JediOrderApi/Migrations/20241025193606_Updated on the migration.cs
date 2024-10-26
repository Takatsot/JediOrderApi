using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JediOrderApi.Migrations
{
    /// <inheritdoc />
    public partial class Updatedonthemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("a568eab1-9ec8-4a87-9f9b-cbd5cdb1a84b"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("b2fe65d3-f4a9-49ad-8430-67f1dac8e83e"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("efd215c8-b1f6-40b0-8eb8-7452fc4168a0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "IsRetired", "Name", "Price", "Type", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9466), new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9476), "A classic Italian pasta dish made with eggs, cheese, pancetta, and pepper.", false, "Spaghetti Carbonara", 12.99m, "Dish", "Admin", "Admin" },
                    { 2, new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9483), new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9484), "Crisp romaine lettuce and croutons dressed with parmesan cheese, lemon juice, olive oil, and Worcestershire sauce.", false, "Caesar Salad", 9.99m, "Dish", "Admin", "Admin" },
                    { 3, new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9489), new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9489), "A refreshing soft drink with a unique taste that has been enjoyed for over a century.", false, "Coca Cola", 1.99m, "Drink", "Admin", "Admin" },
                    { 4, new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9492), new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9492), "Freshly squeezed orange juice, a perfect start to your day.", false, "Orange Juice", 2.49m, "Drink", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "DateCreated", "DateModified", "IsRetired", "ProductsID", "Rating", "ReviewTitle", "UserCreated", "UserId", "UserModified" },
                values: new object[,]
                {
                    { new Guid("a568eab1-9ec8-4a87-9f9b-cbd5cdb1a84b"), "The meal was cold and lacked flavor. The cheese was too much and overpowered everything. Not impressed.", new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9646), new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9647), false, 1, 2, "Not so great", "Bongani", 2, "Bongani" },
                    { new Guid("b2fe65d3-f4a9-49ad-8430-67f1dac8e83e"), "Hi, I had this meal and it was so delicious! Please keep serving it hot. I was very happy.", new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9642), new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9642), false, 1, 5, "Delicious Meal With Extra Cheese", "Noma", 1, "Noma" },
                    { new Guid("efd215c8-b1f6-40b0-8eb8-7452fc4168a0"), "This drink was amazing! I loved the refreshing taste and the blend of flavors was perfect. Will definitely buy again.", new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9650), new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9650), false, 2, 5, "Fantastic Experience", "Sihle", 3, "Sihle" }
                });
        }
    }
}
