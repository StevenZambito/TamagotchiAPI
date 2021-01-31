using Microsoft.EntityFrameworkCore.Migrations;

namespace TamagotchiAPI.Migrations
{
    public partial class ChangesFeedingWhenToLowercase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WHen",
                table: "Feedings",
                newName: "When");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "When",
                table: "Feedings",
                newName: "WHen");
        }
    }
}
