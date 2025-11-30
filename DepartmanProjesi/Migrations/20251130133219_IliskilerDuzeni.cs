using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepartmanProjesi.Migrations
{
    /// <inheritdoc />
    public partial class IliskilerDuzeni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personels_departmanlars_departDepID",
                table: "personels");

            migrationBuilder.RenameColumn(
                name: "departDepID",
                table: "personels",
                newName: "DepartID");

            migrationBuilder.RenameIndex(
                name: "IX_personels_departDepID",
                table: "personels",
                newName: "IX_personels_DepartID");

            migrationBuilder.AddForeignKey(
                name: "FK_personels_departmanlars_DepartID",
                table: "personels",
                column: "DepartID",
                principalTable: "departmanlars",
                principalColumn: "DepID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personels_departmanlars_DepartID",
                table: "personels");

            migrationBuilder.RenameColumn(
                name: "DepartID",
                table: "personels",
                newName: "departDepID");

            migrationBuilder.RenameIndex(
                name: "IX_personels_DepartID",
                table: "personels",
                newName: "IX_personels_departDepID");

            migrationBuilder.AddForeignKey(
                name: "FK_personels_departmanlars_departDepID",
                table: "personels",
                column: "departDepID",
                principalTable: "departmanlars",
                principalColumn: "DepID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
