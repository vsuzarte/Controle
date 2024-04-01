using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financeiro.Models
{
    [Table("Salarios")]
    public class Salario
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe um Sálario")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Informe o dia do pagamento")]
        [Display(Name = "Dia do Pagamento")]
        public int DiaPagamento { get; set; }

        public int PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }

        public int SalarioCategoriaId { get; set; }

        public SalarioCategoria SalarioCategoria { get; set; }

    }
}
