using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicles.API.Migrations
{
    public partial class AddTableProceduress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_procedures",
                table: "procedures");

            migrationBuilder.RenameTable(
                name: "procedures",
                newName: "Procedures");

            migrationBuilder.RenameIndex(
                name: "IX_procedures_Description",
                table: "Procedures",
                newName: "IX_Procedures_Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Procedures",
                table: "Procedures",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Procedures",
                table: "Procedures");

            migrationBuilder.RenameTable(
                name: "Procedures",
                newName: "procedures");

            migrationBuilder.RenameIndex(
                name: "IX_Procedures_Description",
                table: "procedures",
                newName: "IX_procedures_Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_procedures",
                table: "procedures",
                column: "Id");
        }
    }
}
