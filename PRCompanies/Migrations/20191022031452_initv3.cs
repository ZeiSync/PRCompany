using Microsoft.EntityFrameworkCore.Migrations;

namespace PRCompanies.Migrations
{
    public partial class initv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C_PLs_ProgrammingLanguages_ProgrammingLanguageId",
                table: "C_PLs");

            migrationBuilder.DropColumn(
                name: "ProgramingLanguageId",
                table: "C_PLs");

            migrationBuilder.AlterColumn<int>(
                name: "ProgrammingLanguageId",
                table: "C_PLs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_C_PLs_ProgrammingLanguages_ProgrammingLanguageId",
                table: "C_PLs",
                column: "ProgrammingLanguageId",
                principalTable: "ProgrammingLanguages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C_PLs_ProgrammingLanguages_ProgrammingLanguageId",
                table: "C_PLs");

            migrationBuilder.AlterColumn<int>(
                name: "ProgrammingLanguageId",
                table: "C_PLs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ProgramingLanguageId",
                table: "C_PLs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_C_PLs_ProgrammingLanguages_ProgrammingLanguageId",
                table: "C_PLs",
                column: "ProgrammingLanguageId",
                principalTable: "ProgrammingLanguages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
