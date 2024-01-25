using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examen.Migrations
{
    /// <inheritdoc />
    public partial class examenthird : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "AutoriCarti");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AutoriCarti",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
