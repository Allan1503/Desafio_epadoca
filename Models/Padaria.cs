// Padaria.cs
using System.ComponentModel.DataAnnotations;

namespace Desafio_epadoca.Models
{
    public class Padaria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        public string? Endereco { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        public string? Telefone { get; set; }
    }
}
