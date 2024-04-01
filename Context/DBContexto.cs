using Financeiro.Models;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Context
{
    public class DBContexto : DbContext
    {
        public DBContexto(DbContextOptions<DBContexto> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Passivo> Passivos { get; set; }

        public DbSet<Ativo> Ativos { get; set; }

        public DbSet<Salario> Salarios { get; set; }

        public DbSet<SalarioCategoria> SalarioCategorias { get; set; }

    }
}
