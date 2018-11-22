using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeTradeCenter.Migrations
{
    public partial class AddCreator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Ad",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Ad");
        }
    }
}
