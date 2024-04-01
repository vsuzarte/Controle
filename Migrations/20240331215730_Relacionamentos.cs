using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Financeiro.Migrations
{
    public partial class Relacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Salarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalarioCategoriaId",
                table: "Salarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Passivos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Passivos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Ativos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SalarioCatetorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalarioCatetorias", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Salarios_PessoaId",
                table: "Salarios",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Salarios_SalarioCategoriaId",
                table: "Salarios",
                column: "SalarioCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Passivos_CategoriaId",
                table: "Passivos",
                column: "CategoriaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passivos_PessoaId",
                table: "Passivos",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ativos_PessoaId",
                table: "Ativos",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ativos_Pessoas_PessoaId",
                table: "Ativos",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Passivos_Categorias_CategoriaId",
                table: "Passivos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Passivos_Pessoas_PessoaId",
                table: "Passivos",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salarios_Pessoas_PessoaId",
                table: "Salarios",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salarios_SalarioCatetorias_SalarioCategoriaId",
                table: "Salarios",
                column: "SalarioCategoriaId",
                principalTable: "SalarioCatetorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ativos_Pessoas_PessoaId",
                table: "Ativos");

            migrationBuilder.DropForeignKey(
                name: "FK_Passivos_Categorias_CategoriaId",
                table: "Passivos");

            migrationBuilder.DropForeignKey(
                name: "FK_Passivos_Pessoas_PessoaId",
                table: "Passivos");

            migrationBuilder.DropForeignKey(
                name: "FK_Salarios_Pessoas_PessoaId",
                table: "Salarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Salarios_SalarioCatetorias_SalarioCategoriaId",
                table: "Salarios");

            migrationBuilder.DropTable(
                name: "SalarioCatetorias");

            migrationBuilder.DropIndex(
                name: "IX_Salarios_PessoaId",
                table: "Salarios");

            migrationBuilder.DropIndex(
                name: "IX_Salarios_SalarioCategoriaId",
                table: "Salarios");

            migrationBuilder.DropIndex(
                name: "IX_Passivos_CategoriaId",
                table: "Passivos");

            migrationBuilder.DropIndex(
                name: "IX_Passivos_PessoaId",
                table: "Passivos");

            migrationBuilder.DropIndex(
                name: "IX_Ativos_PessoaId",
                table: "Ativos");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Salarios");

            migrationBuilder.DropColumn(
                name: "SalarioCategoriaId",
                table: "Salarios");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Passivos");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Passivos");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Ativos");
        }
    }
}
