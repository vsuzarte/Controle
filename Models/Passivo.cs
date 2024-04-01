using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financeiro.Models
{
    [Table("Passivos")]
    public class Passivo
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Valor Recebido")]
        public double Valor { get; set; }

        [Required]
        [Display(Name = "Data de Recebimento")]
        public DateTime Data { get; set; }

        [Required]
        public bool Recorrente { get; set; }

        [Required]
        [Display(Name = "Quantidade de Parcelas")]
        public int Parcelas { get; set; }

        public int PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; }
    }
}
