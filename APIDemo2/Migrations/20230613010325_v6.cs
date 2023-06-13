using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIDemo2.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Details");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Details",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
