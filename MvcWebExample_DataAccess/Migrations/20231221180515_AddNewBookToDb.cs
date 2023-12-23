using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcWebExample_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddNewBookToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IdBook", "ISBN", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "123123", 10m, "Harry Potter 1" },
                    { 2, "121123", 11m, "Harry Potter 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IdBook",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IdBook",
                keyValue: 2);
        }
    }
}
