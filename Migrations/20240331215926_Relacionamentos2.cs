using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Financeiro.Migrations
{
    public partial class Relacionamentos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Salarios_SalarioCategoriaId",
                table: "Salarios");

            migrationBuilder.CreateIndex(
                name: "IX_Salarios_SalarioCategoriaId",
                table: "Salarios",
                column: "SalarioCategoriaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Salarios_SalarioCategoriaId",
                table: "Salarios");

            migrationBuilder.CreateIndex(
                name: "IX_Salarios_SalarioCategoriaId",
                table: "Salarios",
                column: "SalarioCategoriaId");
        }
    }
}
