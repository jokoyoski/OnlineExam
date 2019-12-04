using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamApp.API.Migrations
{
    public partial class InitialCategoryPhoto4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DigitalFileId",
                table: "Categories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DigitalFileId",
                table: "Categories",
                column: "DigitalFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_DigitalFiles_DigitalFileId",
                table: "Categories",
                column: "DigitalFileId",
                principalTable: "DigitalFiles",
                principalColumn: "DigitalFileId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_DigitalFiles_DigitalFileId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_DigitalFileId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DigitalFileId",
                table: "Categories");
        }
    }
}
