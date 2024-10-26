using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JediOrderApi.Migrations
{
    /// <inheritdoc />
    public partial class Updateddbchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("2a7d7622-1c0d-49c7-842d-ef4c87c2e092"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("76689114-895f-4b01-bbd2-076522efc043"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("b4454ca6-388f-4d66-90c1-2b5dee6d51de"));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Review",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Image",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1706), new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1720), new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1724), new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1727), new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "DateCreated", "DateModified", "IsRetired", "ProductsID", "Rating", "ReviewTitle", "UserCreated", "UserId", "UserModified" },
                values: new object[,]
                {
                    { 1, "Hi, I had this meal and it was so delicious! Please keep serving it hot. I was very happy.", new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1847), new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1847), false, 1, 5, "Delicious Meal With Extra Cheese", "Noma", 1, "Noma" },
                    { 2, "The meal was cold and lacked flavor. The cheese was too much and overpowered everything. Not impressed.", new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1850), new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1850), false, 1, 2, "Not so great", "Bongani", 2, "Bongani" },
                    { 3, "This drink was amazing! I loved the refreshing taste and the blend of flavors was perfect. Will definitely buy again.", new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1852), new DateTime(2024, 10, 26, 11, 7, 26, 362, DateTimeKind.Local).AddTicks(1853), false, 2, 5, "Fantastic Experience", "Sihle", 3, "Sihle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(829), new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(846), new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(848), new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(851), new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "DateCreated", "DateModified", "IsRetired", "ProductsID", "Rating", "ReviewTitle", "UserCreated", "UserId", "UserModified" },
                values: new object[,]
                {
                    { new Guid("2a7d7622-1c0d-49c7-842d-ef4c87c2e092"), "This drink was amazing! I loved the refreshing taste and the blend of flavors was perfect. Will definitely buy again.", new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(1026), new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(1027), false, 2, 5, "Fantastic Experience", "Sihle", 3, "Sihle" },
                    { new Guid("76689114-895f-4b01-bbd2-076522efc043"), "Hi, I had this meal and it was so delicious! Please keep serving it hot. I was very happy.", new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(1019), new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(1020), false, 1, 5, "Delicious Meal With Extra Cheese", "Noma", 1, "Noma" },
                    { new Guid("b4454ca6-388f-4d66-90c1-2b5dee6d51de"), "The meal was cold and lacked flavor. The cheese was too much and overpowered everything. Not impressed.", new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(1023), new DateTime(2024, 10, 26, 9, 41, 7, 193, DateTimeKind.Local).AddTicks(1024), false, 1, 2, "Not so great", "Bongani", 2, "Bongani" }
                });
        }
    }
}
