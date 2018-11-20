using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeTradeCenter.Migrations
{
    public partial class AddMovesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Move1",
                table: "Ad");

            migrationBuilder.DropColumn(
                name: "Move2",
                table: "Ad");

            migrationBuilder.DropColumn(
                name: "Move3",
                table: "Ad");

            migrationBuilder.DropColumn(
                name: "Move4",
                table: "Ad");

            migrationBuilder.AddColumn<int>(
                name: "Move1ID",
                table: "Ad",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Move2ID",
                table: "Ad",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Move3ID",
                table: "Ad",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Move4ID",
                table: "Ad",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MoveType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PokemonMove",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonMove", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PokemonMove_MoveType_TypeID",
                        column: x => x.TypeID,
                        principalTable: "MoveType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ad_Move1ID",
                table: "Ad",
                column: "Move1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Ad_Move2ID",
                table: "Ad",
                column: "Move2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Ad_Move3ID",
                table: "Ad",
                column: "Move3ID");

            migrationBuilder.CreateIndex(
                name: "IX_Ad_Move4ID",
                table: "Ad",
                column: "Move4ID");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMove_TypeID",
                table: "PokemonMove",
                column: "TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ad_PokemonMove_Move1ID",
                table: "Ad",
                column: "Move1ID",
                principalTable: "PokemonMove",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ad_PokemonMove_Move2ID",
                table: "Ad",
                column: "Move2ID",
                principalTable: "PokemonMove",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ad_PokemonMove_Move3ID",
                table: "Ad",
                column: "Move3ID",
                principalTable: "PokemonMove",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ad_PokemonMove_Move4ID",
                table: "Ad",
                column: "Move4ID",
                principalTable: "PokemonMove",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ad_PokemonMove_Move1ID",
                table: "Ad");

            migrationBuilder.DropForeignKey(
                name: "FK_Ad_PokemonMove_Move2ID",
                table: "Ad");

            migrationBuilder.DropForeignKey(
                name: "FK_Ad_PokemonMove_Move3ID",
                table: "Ad");

            migrationBuilder.DropForeignKey(
                name: "FK_Ad_PokemonMove_Move4ID",
                table: "Ad");

            migrationBuilder.DropTable(
                name: "PokemonMove");

            migrationBuilder.DropTable(
                name: "MoveType");

            migrationBuilder.DropIndex(
                name: "IX_Ad_Move1ID",
                table: "Ad");

            migrationBuilder.DropIndex(
                name: "IX_Ad_Move2ID",
                table: "Ad");

            migrationBuilder.DropIndex(
                name: "IX_Ad_Move3ID",
                table: "Ad");

            migrationBuilder.DropIndex(
                name: "IX_Ad_Move4ID",
                table: "Ad");

            migrationBuilder.DropColumn(
                name: "Move1ID",
                table: "Ad");

            migrationBuilder.DropColumn(
                name: "Move2ID",
                table: "Ad");

            migrationBuilder.DropColumn(
                name: "Move3ID",
                table: "Ad");

            migrationBuilder.DropColumn(
                name: "Move4ID",
                table: "Ad");

            migrationBuilder.AddColumn<int>(
                name: "Move1",
                table: "Ad",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Move2",
                table: "Ad",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Move3",
                table: "Ad",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Move4",
                table: "Ad",
                nullable: false,
                defaultValue: 0);
        }
    }
}
