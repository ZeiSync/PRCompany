using Microsoft.EntityFrameworkCore.Migrations;

namespace PRCompanies.Migrations
{
    public partial class initv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyType",
                table: "Companies",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyType",
                table: "Companies");
        }
    }
}
