using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JediOrderApi.Migrations
{
    /// <inheritdoc />
    public partial class Updatedimagetables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("a0d05bc6-c20e-4624-b24a-c4e70adb4f0f"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("f7699b55-fcf6-47c7-858f-e3bd8966ab10"));

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("fc9a5cde-9e54-48cf-8cc5-03a8f84135c4"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1730), new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1743), new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1747), new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1749), new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "DateCreated", "DateModified", "IsRetired", "ProductsID", "Rating", "ReviewTitle", "UserCreated", "UserId", "UserModified" },
                values: new object[,]
                {
                    { new Guid("a0d05bc6-c20e-4624-b24a-c4e70adb4f0f"), "Hi, I had this meal and it was so delicious! Please keep serving it hot. I was very happy.", new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1888), new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1890), false, 1, 5, "Delicious Meal With Extra Cheese", "Noma", 1, "Noma" },
                    { new Guid("f7699b55-fcf6-47c7-858f-e3bd8966ab10"), "The meal was cold and lacked flavor. The cheese was too much and overpowered everything. Not impressed.", new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1894), new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1894), false, 1, 2, "Not so great", "Bongani", 2, "Bongani" },
                    { new Guid("fc9a5cde-9e54-48cf-8cc5-03a8f84135c4"), "This drink was amazing! I loved the refreshing taste and the blend of flavors was perfect. Will definitely buy again.", new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1907), new DateTime(2024, 10, 25, 22, 28, 13, 218, DateTimeKind.Local).AddTicks(1907), false, 2, 5, "Fantastic Experience", "Sihle", 3, "Sihle" }
                });
        }
    }
}
