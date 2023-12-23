using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcWebExample_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update_FluentBookDetailViaFluentAPI2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfPages",
                table: "Fluent_BookDetail");

            migrationBuilder.AlterColumn<string>(
                name: "Weight",
                table: "Fluent_BookDetail",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Weight",
                table: "Fluent_BookDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPages",
                table: "Fluent_BookDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
