using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JediOrderApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedReviewPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.AddColumn<bool>(
                name: "IsRetired",
                table: "Review",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRetired",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRetired",
                table: "Image",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "IsRetired" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6877), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6887), false });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "IsRetired" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6891), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6891), false });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "IsRetired" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6894), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6894), false });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "IsRetired" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6897), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(6897), false });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "IsRetired", "ReviewsID" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(7020), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(7021), false, new Guid("563837c4-9f6e-4183-9ede-3bf4c196575a") });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "IsRetired", "ReviewsID" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(7024), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(7025), false, new Guid("b3809d67-9346-403c-b8df-fd8e0ba1bdc1") });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "IsRetired", "ReviewsID" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(7028), new DateTime(2024, 10, 25, 19, 28, 39, 819, DateTimeKind.Local).AddTicks(7028), false, new Guid("d838305f-b761-4c3e-aae1-34a3a346ece4") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRetired",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "IsRetired",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsRetired",
                table: "Image");

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "99ea951c-bba5-41be-a465-dd5a82507c3f", "99ea951c-bba5-41be-a465-dd5a82507c3f", "Writer", "WRITER" },
                    { "dd99353d-ae6f-4d98-9176-98a79f9ea28a", "dd99353d-ae6f-4d98-9176-98a79f9ea28a", "Reader", "READER" }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4061), new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4099), new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4104), new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4108), new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "ReviewsID" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4427), new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4428), new Guid("ec0946aa-f2a7-47d0-a25a-77d9b9ac2220") });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "ReviewsID" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4433), new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4433), new Guid("4346c54a-1341-4643-97d4-9f8db5901660") });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "ReviewsID" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4437), new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4437), new Guid("c73f6439-e51d-4b1a-8b80-012abb788915") });
        }
    }
}
