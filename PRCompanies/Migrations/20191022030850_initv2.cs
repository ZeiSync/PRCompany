using Microsoft.EntityFrameworkCore.Migrations;

namespace PRCompanies.Migrations
{
    public partial class initv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Overviews_CompanyId",
                table: "Overviews");

            migrationBuilder.CreateIndex(
                name: "IX_Overviews_CompanyId",
                table: "Overviews",
                column: "CompanyId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Overviews_CompanyId",
                table: "Overviews");

            migrationBuilder.CreateIndex(
                name: "IX_Overviews_CompanyId",
                table: "Overviews",
                column: "CompanyId");
        }
    }
}
