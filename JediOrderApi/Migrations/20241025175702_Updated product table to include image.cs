using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JediOrderApi.Migrations
{
    /// <inheritdoc />
    public partial class Updatedproducttabletoincludeimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("6e1c19c4-05c6-4501-9c86-2e1808cbf24c"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("733d4982-4564-47c0-9f0d-963dfb1d816b"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("8e7b28e7-e242-4cf3-8d33-fdede23a429b"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Image",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(770), new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(794), new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(798), new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(802), new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "DateCreated", "DateModified", "IsRetired", "ProductsID", "Rating", "ReviewTitle", "UserCreated", "UserId", "UserModified" },
                values: new object[,]
                {
                    { new Guid("630cac8e-530b-48ee-ad8b-6b37b611bcc4"), "This drink was amazing! I loved the refreshing taste and the blend of flavors was perfect. Will definitely buy again.", new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(1015), new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(1016), false, 2, 5, "Fantastic Experience", "Sihle", 3, "Sihle" },
                    { new Guid("8da23478-53ca-4e65-bc8c-3c9a0d4a0a2d"), "Hi, I had this meal and it was so delicious! Please keep serving it hot. I was very happy.", new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(1005), new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(1006), false, 1, 5, "Delicious Meal With Extra Cheese", "Noma", 1, "Noma" },
                    { new Guid("90747912-0d3c-4f23-b94c-c4b22da40081"), "The meal was cold and lacked flavor. The cheese was too much and overpowered everything. Not impressed.", new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(1011), new DateTime(2024, 10, 25, 19, 57, 1, 454, DateTimeKind.Local).AddTicks(1011), false, 1, 2, "Not so great", "Bongani", 2, "Bongani" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                column: "ProductId",
                unique: true,
                filter: "[ProductId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Product_ProductId",
                table: "Image",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Product_ProductId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_ProductId",
                table: "Image");

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("630cac8e-530b-48ee-ad8b-6b37b611bcc4"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("8da23478-53ca-4e65-bc8c-3c9a0d4a0a2d"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("90747912-0d3c-4f23-b94c-c4b22da40081"));

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Image");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2056), new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2066), "Spaghetti-image.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2070), new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2070), "Caesar-image.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2073), new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2073), "Coke-image.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "ImageUrl" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2075), new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2076), "Orange-image.jpg" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "DateCreated", "DateModified", "IsRetired", "ProductsID", "Rating", "ReviewTitle", "UserCreated", "UserId", "UserModified" },
                values: new object[,]
                {
                    { new Guid("6e1c19c4-05c6-4501-9c86-2e1808cbf24c"), "This drink was amazing! I loved the refreshing taste and the blend of flavors was perfect. Will definitely buy again.", new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2195), new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2196), false, 2, 5, "Fantastic Experience", "Sihle", 3, "Sihle" },
                    { new Guid("733d4982-4564-47c0-9f0d-963dfb1d816b"), "Hi, I had this meal and it was so delicious! Please keep serving it hot. I was very happy.", new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2189), new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2189), false, 1, 5, "Delicious Meal With Extra Cheese", "Noma", 1, "Noma" },
                    { new Guid("8e7b28e7-e242-4cf3-8d33-fdede23a429b"), "The meal was cold and lacked flavor. The cheese was too much and overpowered everything. Not impressed.", new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2192), new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2193), false, 1, 2, "Not so great", "Bongani", 2, "Bongani" }
                });
        }
    }
}
