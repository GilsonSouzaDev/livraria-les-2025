using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace livraria_api.api.Domain.Models
{
    public class TelefoneCliente
    {
        public int TelefoneId { get; set; }

        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O tipo de telefone é obrigatório.")]
        public string TipoTelefone { get; set; } = null!;

        [Required(ErrorMessage = "O DDD é obrigatório.")]
        [RegularExpression(@"^\d{2}$", ErrorMessage = "O DDD deve ter exatamente 2 dígitos numéricos.")]
        public string Ddd { get; set; } = null!;

        [Required(ErrorMessage = "O número de telefone é obrigatório.")]
        [RegularExpression(@"^\d{8,9}$", ErrorMessage = "O número de telefone deve ter exatamente 8 ou 9 dígitos numéricos (ex: 912345678, 46335525).")]
        public string Numero { get; set; } = null!;

        [JsonIgnore]
        public virtual Cliente Cliente { get; set; } = null!;
    }
}
