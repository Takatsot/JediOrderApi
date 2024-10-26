using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JediOrderApi.Migrations
{
    /// <inheritdoc />
    public partial class Updatedtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3811), new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3828), new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3831), new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3835), new DateTime(2024, 10, 25, 21, 37, 48, 348, DateTimeKind.Local).AddTicks(3835) });

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
    }
}
