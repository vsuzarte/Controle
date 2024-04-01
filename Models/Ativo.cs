using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financeiro.Models
{
    [Table("Ativos")]
    public class Ativo
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do recebimento")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o valor a receber")]
        [Display(Name = "Valor a Pagar")]
        [Range(0, double.MaxValue)]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Informe a data do recebimento")]
        [Display(Name = "Data do Pagamento")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Informe se o recebimento é recorrente")]
        [Display(Name = "Recorrente")]
        public bool Recorrente { get; set; }

        [Display(Name = "Quantidade de Parcelas")]
        public int Parcelas { get; set; } = 1;

        public int PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
