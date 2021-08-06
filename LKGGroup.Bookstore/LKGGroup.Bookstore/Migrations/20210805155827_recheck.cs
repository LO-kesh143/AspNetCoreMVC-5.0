using Microsoft.EntityFrameworkCore.Migrations;

namespace LKGGroup.Bookstore.Migrations
{
    public partial class recheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhNumber",
                table: "AspNetUsers");
        }
    }
}
