using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    public partial class initDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    IdDocument = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentNumber = table.Column<int>(type: "int", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.IdDocument);
                });

            migrationBuilder.CreateTable(
                name: "Genger",
                columns: table => new
                {
                    IdGenger = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    genger = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genger", x => x.IdGenger);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    IdClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdDocument = table.Column<int>(type: "int", nullable: false),
                    documentIdDocument = table.Column<int>(type: "int", nullable: false),
                    IdGenger = table.Column<int>(type: "int", nullable: false),
                    GengerIdGenger = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.IdClient);
                    table.ForeignKey(
                        name: "FK_Client_Document_documentIdDocument",
                        column: x => x.documentIdDocument,
                        principalTable: "Document",
                        principalColumn: "IdDocument",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Genger_GengerIdGenger",
                        column: x => x.GengerIdGenger,
                        principalTable: "Genger",
                        principalColumn: "IdGenger",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_documentIdDocument",
                table: "Client",
                column: "documentIdDocument");

            migrationBuilder.CreateIndex(
                name: "IX_Client_GengerIdGenger",
                table: "Client",
                column: "GengerIdGenger");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Genger");
        }
    }
}
