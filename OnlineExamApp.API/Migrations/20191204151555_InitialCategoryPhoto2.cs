using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamApp.API.Migrations
{
    public partial class InitialCategoryPhoto2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_DigitalFiles_DigitalFilesDigitalFileId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_DigitalFilesDigitalFileId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DigitalFilesDigitalFileId",
                table: "Categories");

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

            migrationBuilder.AddColumn<int>(
                name: "DigitalFilesDigitalFileId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DigitalFilesDigitalFileId",
                table: "Categories",
                column: "DigitalFilesDigitalFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_DigitalFiles_DigitalFilesDigitalFileId",
                table: "Categories",
                column: "DigitalFilesDigitalFileId",
                principalTable: "DigitalFiles",
                principalColumn: "DigitalFileId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
