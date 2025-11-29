using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepartmanProjesi.Migrations
{
    /// <inheritdoc />
    public partial class IliskilerDuzenlendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departDepID",
                table: "personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_personels_departDepID",
                table: "personels",
                column: "departDepID");

            migrationBuilder.AddForeignKey(
                name: "FK_personels_departmanlars_departDepID",
                table: "personels",
                column: "departDepID",
                principalTable: "departmanlars",
                principalColumn: "DepID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personels_departmanlars_departDepID",
                table: "personels");

            migrationBuilder.DropIndex(
                name: "IX_personels_departDepID",
                table: "personels");

            migrationBuilder.DropColumn(
                name: "departDepID",
                table: "personels");
        }
    }
}
