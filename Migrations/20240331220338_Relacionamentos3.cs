using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Financeiro.Migrations
{
    public partial class Relacionamentos3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Salarios_SalarioCategoriaId",
                table: "Salarios");

            migrationBuilder.DropIndex(
                name: "IX_Passivos_CategoriaId",
                table: "Passivos");

            migrationBuilder.CreateIndex(
                name: "IX_Salarios_SalarioCategoriaId",
                table: "Salarios",
                column: "SalarioCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Passivos_CategoriaId",
                table: "Passivos",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Salarios_SalarioCategoriaId",
                table: "Salarios");

            migrationBuilder.DropIndex(
                name: "IX_Passivos_CategoriaId",
                table: "Passivos");

            migrationBuilder.CreateIndex(
                name: "IX_Salarios_SalarioCategoriaId",
                table: "Salarios",
                column: "SalarioCategoriaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passivos_CategoriaId",
                table: "Passivos",
                column: "CategoriaId",
                unique: true);
        }
    }
}
