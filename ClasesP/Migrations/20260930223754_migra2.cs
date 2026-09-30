using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesP.Migrations
{
    /// <inheritdoc />
    public partial class migra2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistaId",
                table: "Canciones",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Canciones_ArtistaId",
                table: "Canciones",
                column: "ArtistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Canciones_Artistas_ArtistaId",
                table: "Canciones",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_Artistas_ArtistaId",
                table: "Canciones");

            migrationBuilder.DropIndex(
                name: "IX_Canciones_ArtistaId",
                table: "Canciones");

            migrationBuilder.DropColumn(
                name: "ArtistaId",
                table: "Canciones");
        }
    }
}
