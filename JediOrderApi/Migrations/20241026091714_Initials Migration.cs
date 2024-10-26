using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JediOrderApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserModified = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRetired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeInBytes = table.Column<long>(type: "bigint", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserModified = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRetired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ReviewTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserModified = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRetired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Product_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "IsRetired", "Name", "Price", "Type", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9444), "A classic Italian pasta dish made with eggs, cheese, pancetta, and pepper.", false, "Spaghetti Carbonara", 12.99m, "Dish", "Admin", "Admin" },
                    { 2, new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9449), new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9450), "Crisp romaine lettuce and croutons dressed with parmesan cheese, lemon juice, olive oil, and Worcestershire sauce.", false, "Caesar Salad", 9.99m, "Dish", "Admin", "Admin" },
                    { 3, new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9453), new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9453), "A refreshing soft drink with a unique taste that has been enjoyed for over a century.", false, "Coca Cola", 1.99m, "Drink", "Admin", "Admin" },
                    { 4, new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9456), new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9457), "Freshly squeezed orange juice, a perfect start to your day.", false, "Orange Juice", 2.49m, "Drink", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "DateCreated", "DateModified", "IsRetired", "ProductsID", "Rating", "ReviewTitle", "UserCreated", "UserId", "UserModified" },
                values: new object[,]
                {
                    { 1, "Hi, I had this meal and it was so delicious! Please keep serving it hot. I was very happy.", new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9566), new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9567), false, 1, 5, "Delicious Meal With Extra Cheese", "Noma", 1, "Noma" },
                    { 2, "The meal was cold and lacked flavor. The cheese was too much and overpowered everything. Not impressed.", new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9572), new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9573), false, 1, 2, "Not so great", "Bongani", 2, "Bongani" },
                    { 3, "This drink was amazing! I loved the refreshing taste and the blend of flavors was perfect. Will definitely buy again.", new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9576), new DateTime(2024, 10, 26, 11, 17, 14, 8, DateTimeKind.Local).AddTicks(9576), false, 2, 5, "Fantastic Experience", "Sihle", 3, "Sihle" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                column: "ProductId",
                unique: true,
                filter: "[ProductId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Name",
                table: "Product",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review_ProductsID",
                table: "Review",
                column: "ProductsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
