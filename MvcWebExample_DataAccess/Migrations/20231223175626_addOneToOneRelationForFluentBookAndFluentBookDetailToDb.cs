using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcWebExample_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addOneToOneRelationForFluentBookAndFluentBookDetailToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Fluent_BookDetail_BookDetail_Id",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_BookDetail_Id",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "BookDetail_Id",
                table: "Fluent_Books");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Fluent_BookDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookDetail_BookId",
                table: "Fluent_BookDetail",
                column: "BookId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookDetail_Fluent_Books_BookId",
                table: "Fluent_BookDetail",
                column: "BookId",
                principalTable: "Fluent_Books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookDetail_Fluent_Books_BookId",
                table: "Fluent_BookDetail");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_BookDetail_BookId",
                table: "Fluent_BookDetail");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Fluent_BookDetail");

            migrationBuilder.AddColumn<int>(
                name: "BookDetail_Id",
                table: "Fluent_Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_BookDetail_Id",
                table: "Fluent_Books",
                column: "BookDetail_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_Fluent_BookDetail_BookDetail_Id",
                table: "Fluent_Books",
                column: "BookDetail_Id",
                principalTable: "Fluent_BookDetail",
                principalColumn: "BookDetail_Id");
        }
    }
}
