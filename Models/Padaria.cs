using System.ComponentModel.DataAnnotations;

namespace Epadoca.Models
{
    public class Padaria
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string InformacoesCadastrais { get; set; }

        public string Endereco { get; set; }
    }
}
