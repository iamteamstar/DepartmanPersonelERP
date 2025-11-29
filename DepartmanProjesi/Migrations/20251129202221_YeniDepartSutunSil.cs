using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepartmanProjesi.Migrations
{
    /// <inheritdoc />
    public partial class YeniDepartSutunSil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepDetay",
                table: "departmanlars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepDetay",
                table: "departmanlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
