using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamApp.API.Migrations
{
    public partial class trials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Trials",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Trials",
                table: "AspNetUsers");
        }
    }
}
