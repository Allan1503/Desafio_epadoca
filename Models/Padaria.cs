using System.ComponentModel.DataAnnotations;

namespace Desafio_epadoca.Models
{
    public class Padaria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        public string? InformacoesCadastrais { get; set; }
        
        public string? Endereco { get; set; }

        public Padaria()
        {
            Nome = string.Empty; // Ou atribua outro valor padrão desejado
        }
    }
}
