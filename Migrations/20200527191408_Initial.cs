using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstExercise.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrapSamples",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Collection = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Collector = table.Column<string>(nullable: true),
                    Analyst = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrapSamples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specimens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Species = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    TrapSampleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specimens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specimens_TrapSamples_TrapSampleId",
                        column: x => x.TrapSampleId,
                        principalTable: "TrapSamples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Specimens_TrapSampleId",
                table: "Specimens",
                column: "TrapSampleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Specimens");

            migrationBuilder.DropTable(
                name: "TrapSamples");
        }
    }
}
