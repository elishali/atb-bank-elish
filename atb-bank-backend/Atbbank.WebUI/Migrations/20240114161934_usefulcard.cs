using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Atbbank.WebUI.Migrations
{
    public partial class usefulcard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "UsefulCards",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "UsefulCards");
        }
    }
}
