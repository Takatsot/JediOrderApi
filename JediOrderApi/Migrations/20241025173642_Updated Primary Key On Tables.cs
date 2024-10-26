using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JediOrderApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPrimaryKeyOnTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ReviewsID",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "ImageGuid",
                table: "Image");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Review",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Image",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2056), new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2070), new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2073), new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2075), new DateTime(2024, 10, 25, 19, 36, 41, 706, DateTimeKind.Local).AddTicks(2076) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Review",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "ReviewsID",
                table: "Review",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Image",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "ImageGuid",
                table: "Image",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6877), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6891), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6894), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6897), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6897) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "DateCreated", "DateModified", "IsRetired", "ProductsID", "Rating", "ReviewTitle", "ReviewsID", "UserCreated", "UserId", "UserModified" },
                values: new object[,]
                {
                    { 1, "Hi, I had this meal and it was so delicious! Please keep serving it hot. I was very happy.", new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(7020), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(7021), false, 1, 5, "Delicious Meal With Extra Cheese", new Guid("563837c4-9f6e-4183-9ede-3bf4c196575a"), "Noma", 1, "Noma" },
                    { 2, "The meal was cold and lacked flavor. The cheese was too much and overpowered everything. Not impressed.", new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(7024), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(7025), false, 1, 2, "Not so great", new Guid("b3809d67-9346-403c-b8df-fd8e0ba1bdc1"), "Bongani", 2, "Bongani" },
                    { 3, "This drink was amazing! I loved the refreshing taste and the blend of flavors was perfect. Will definitely buy again.", new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(7028), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(7028), false, 2, 5, "Fantastic Experience", new Guid("d838305f-b761-4c3e-aae1-34a3a346ece4"), "Sihle", 3, "Sihle" }
                });
        }
    }
}
