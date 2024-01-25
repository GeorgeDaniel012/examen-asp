using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examen.Migrations
{
    /// <inheritdoc />
    public partial class examensecond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carte_Autor_AutorId",
                table: "Carte");

            migrationBuilder.DropIndex(
                name: "IX_Carte_AutorId",
                table: "Carte");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Carte");

            migrationBuilder.CreateTable(
                name: "AutoriCarti",
                columns: table => new
                {
                    AutorId = table.Column<int>(type: "int", nullable: false),
                    CarteId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoriCarti", x => new { x.AutorId, x.CarteId });
                    table.ForeignKey(
                        name: "FK_AutoriCarti_Autor_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoriCarti_Carte_CarteId",
                        column: x => x.CarteId,
                        principalTable: "Carte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutoriCarti_CarteId",
                table: "AutoriCarti",
                column: "CarteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoriCarti");

            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "Carte",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Carte_AutorId",
                table: "Carte",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carte_Autor_AutorId",
                table: "Carte",
                column: "AutorId",
                principalTable: "Autor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
