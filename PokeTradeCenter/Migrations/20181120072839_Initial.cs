using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeTradeCenter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ad",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pokemon = table.Column<int>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Nature = table.Column<string>(nullable: true),
                    Atk = table.Column<int>(nullable: false),
                    SpeAtk = table.Column<int>(nullable: false),
                    Def = table.Column<int>(nullable: false),
                    SpeDef = table.Column<int>(nullable: false),
                    Speed = table.Column<int>(nullable: false),
                    Hp = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Move1 = table.Column<int>(nullable: false),
                    Move2 = table.Column<int>(nullable: false),
                    Move3 = table.Column<int>(nullable: false),
                    Move4 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ad", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ad");
        }
    }
}
