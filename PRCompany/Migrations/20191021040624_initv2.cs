using Microsoft.EntityFrameworkCore.Migrations;

namespace PRCompany.Migrations
{
    public partial class initv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "ProgrammingLanguage",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProgrammingLanguage",
                newName: "id");
        }
    }
}
