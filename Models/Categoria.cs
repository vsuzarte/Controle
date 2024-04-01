using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financeiro.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        public Categoria()
        {
            Passivos = new List<Passivo>();
        }

        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do recebimento")]
        public string Nome { get; set; }

        public List<Passivo> Passivos { get; }
    }
}
