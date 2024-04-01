using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financeiro.Models
{
    [Table("SalarioCatetorias")]
    public class SalarioCategoria
    {
        public SalarioCategoria()
        {
               Salarios = new List<Salario>();
        }

        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        public string Nome { get; set; }

        public List<Salario> Salarios { get; }
    }
}
