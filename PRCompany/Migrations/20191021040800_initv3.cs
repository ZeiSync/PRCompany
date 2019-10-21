using Microsoft.EntityFrameworkCore.Migrations;

namespace PRCompany.Migrations
{
    public partial class initv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C_PL_Companies_CompanyId",
                table: "C_PL");

            migrationBuilder.DropForeignKey(
                name: "FK_C_PL_ProgrammingLanguage_ProgrammingLanguageId",
                table: "C_PL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgrammingLanguage",
                table: "ProgrammingLanguage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_C_PL",
                table: "C_PL");

            migrationBuilder.RenameTable(
                name: "ProgrammingLanguage",
                newName: "ProgrammingLanguages");

            migrationBuilder.RenameTable(
                name: "C_PL",
                newName: "C_PLs");

            migrationBuilder.RenameIndex(
                name: "IX_C_PL_ProgrammingLanguageId",
                table: "C_PLs",
                newName: "IX_C_PLs_ProgrammingLanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_C_PL_CompanyId",
                table: "C_PLs",
                newName: "IX_C_PLs_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgrammingLanguages",
                table: "ProgrammingLanguages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_C_PLs",
                table: "C_PLs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_C_PLs_Companies_CompanyId",
                table: "C_PLs",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_C_PLs_Companies_CompanyId",
                table: "C_PLs");

            migrationBuilder.DropForeignKey(
                name: "FK_C_PLs_ProgrammingLanguages_ProgrammingLanguageId",
                table: "C_PLs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgrammingLanguages",
                table: "ProgrammingLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_C_PLs",
                table: "C_PLs");

            migrationBuilder.RenameTable(
                name: "ProgrammingLanguages",
                newName: "ProgrammingLanguage");

            migrationBuilder.RenameTable(
                name: "C_PLs",
                newName: "C_PL");

            migrationBuilder.RenameIndex(
                name: "IX_C_PLs_ProgrammingLanguageId",
                table: "C_PL",
                newName: "IX_C_PL_ProgrammingLanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_C_PLs_CompanyId",
                table: "C_PL",
                newName: "IX_C_PL_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgrammingLanguage",
                table: "ProgrammingLanguage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_C_PL",
                table: "C_PL",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_C_PL_Companies_CompanyId",
                table: "C_PL",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_C_PL_ProgrammingLanguage_ProgrammingLanguageId",
                table: "C_PL",
                column: "ProgrammingLanguageId",
                principalTable: "ProgrammingLanguage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
