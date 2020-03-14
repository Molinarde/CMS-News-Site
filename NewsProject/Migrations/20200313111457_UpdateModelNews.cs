using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsProject.Migrations
{
    public partial class UpdateModelNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "News");
        }
    }
}
