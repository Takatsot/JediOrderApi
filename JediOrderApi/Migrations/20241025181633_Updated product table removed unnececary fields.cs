using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JediOrderApi.Migrations
{
    /// <inheritdoc />
    public partial class Updatedproducttableremovedunnececaryfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9466), new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9483), new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9489), new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9492), new DateTime(2024, 10, 25, 20, 16, 33, 115, DateTimeKind.Local).AddTicks(9492) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
