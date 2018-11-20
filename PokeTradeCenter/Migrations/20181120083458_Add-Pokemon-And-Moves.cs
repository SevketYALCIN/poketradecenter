using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeTradeCenter.Migrations
{
    public partial class AddPokemonAndMoves : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nature",
                table: "Ad");

            migrationBuilder.DropColumn(
                name: "Pokemon",
                table: "Ad");

            migrationBuilder.AddColumn<int>(
                name: "NatureID",
                table: "Ad",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PokemonID",
                table: "Ad",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Shiny",
                table: "Ad",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderNumber = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Generation = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PokemonNature",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonNature", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ad_NatureID",
                table: "Ad",
                column: "NatureID");

            migrationBuilder.CreateIndex(
                name: "IX_Ad_PokemonID",
                table: "Ad",
                column: "PokemonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ad_PokemonNature_NatureID",
                table: "Ad",
                column: "NatureID",
                principalTable: "PokemonNature",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ad_Pokemon_PokemonID",
                table: "Ad",
                column: "PokemonID",
                principalTable: "Pokemon",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ad_PokemonNature_NatureID",
                table: "Ad");

            migrationBuilder.DropForeignKey(
                name: "FK_Ad_Pokemon_PokemonID",
                table: "Ad");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "PokemonNature");

            migrationBuilder.DropIndex(
                name: "IX_Ad_NatureID",
                table: "Ad");

            migrationBuilder.DropIndex(
                name: "IX_Ad_PokemonID",
                table: "Ad");

            migrationBuilder.DropColumn(
                name: "NatureID",
                table: "Ad");

            migrationBuilder.DropColumn(
                name: "PokemonID",
                table: "Ad");

            migrationBuilder.DropColumn(
                name: "Shiny",
                table: "Ad");

            migrationBuilder.AddColumn<string>(
                name: "Nature",
                table: "Ad",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pokemon",
                table: "Ad",
                nullable: false,
                defaultValue: 0);
        }
    }
}
