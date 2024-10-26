using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JediOrderApi.Migrations
{
    /// <inheritdoc />
    public partial class AddingImagesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

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

            migrationBuilder.RenameColumn(
                name: "ProductsID",
                table: "Product",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "UserModified",
                table: "Review",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserCreated",
                table: "Review",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeInBytes = table.Column<long>(type: "bigint", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserModified = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "DateCreated", "DateModified", "ProductsID", "Rating", "ReviewTitle", "ReviewsID", "UserCreated", "UserId", "UserModified" },
                values: new object[,]
                {
                    { 1, "Hi, I had this meal and it was so delicious! Please keep serving it hot. I was very happy.", new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4427), new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4428), 1, 5, "Delicious Meal With Extra Cheese", new Guid("ec0946aa-f2a7-47d0-a25a-77d9b9ac2220"), "Noma", 1, "Noma" },
                    { 2, "The meal was cold and lacked flavor. The cheese was too much and overpowered everything. Not impressed.", new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4433), new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4433), 1, 2, "Not so great", new Guid("4346c54a-1341-4643-97d4-9f8db5901660"), "Bongani", 2, "Bongani" },
                    { 3, "This drink was amazing! I loved the refreshing taste and the blend of flavors was perfect. Will definitely buy again.", new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4437), new DateTime(2024, 10, 25, 19, 3, 14, 502, DateTimeKind.Local).AddTicks(4437), 2, 5, "Fantastic Experience", new Guid("c73f6439-e51d-4b1a-8b80-012abb788915"), "Sihle", 3, "Sihle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "ProductsID");

            migrationBuilder.AlterColumn<string>(
                name: "UserModified",
                table: "Review",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserCreated",
                table: "Review",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ReviewsID");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductsID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductsID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7519), new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductsID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7522), new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductsID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7525), new DateTime(2024, 10, 24, 15, 38, 33, 948, DateTimeKind.Local).AddTicks(7526) });

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
    }
}
