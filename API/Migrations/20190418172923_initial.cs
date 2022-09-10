using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Agilistas.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agilistas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PrimaryFocusId = table.Column<Guid>(nullable: false),
                    TwitterHandle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agilistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agilistas_Categories_PrimaryFocusId",
                        column: x => x.PrimaryFocusId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agilistas_PrimaryFocusId",
                table: "Agilistas",
                column: "PrimaryFocusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agilistas");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
