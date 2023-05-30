// Contato.cs
using System.ComponentModel.DataAnnotations;

namespace Desafio_epadoca.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string? Nome { get; set; }

        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo Mensagem é obrigatório.")]
        public string? Mensagem { get; set; }
    }
}
