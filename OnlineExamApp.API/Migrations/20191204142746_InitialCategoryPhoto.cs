using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamApp.API.Migrations
{
    public partial class InitialCategoryPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_DigitalFiles_PhotoId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_PhotoId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "DigitalFileId",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DigitalId",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.DropColumn(
                name: "DigitalId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "PhotoId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_PhotoId",
                table: "Categories",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_DigitalFiles_PhotoId",
                table: "Categories",
                column: "PhotoId",
                principalTable: "DigitalFiles",
                principalColumn: "DigitalFileId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
