using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financeiro.Models
{
    [Table("Pessoas")]
    public class Pessoa
    {
        public Pessoa()
        {
            Salarios = new List<Salario>();
            Ativos = new List<Ativo>(); ;
            Passivos = new List<Passivo>();
        }

        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public List<Salario> Salarios { get; }

        public List<Ativo> Ativos { get; }

        public List<Passivo> Passivos { get; }

    }
}
