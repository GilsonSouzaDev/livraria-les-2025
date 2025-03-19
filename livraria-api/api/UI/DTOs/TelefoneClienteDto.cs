using System.ComponentModel.DataAnnotations;

namespace livraria_api.api.UI.DTOs
{
    public class TelefoneClienteDto
    {
        public int telefoneId { get; set; }
        public int ClienteID { get; set; } // Mantenha o ClienteID
        public string TipoTelefone { get; set; }

        [Required(ErrorMessage = "O ddd do telefone é obrigatório.")]
        public string Ddd { get; set; }

        [Required(ErrorMessage = "O número de telefone é obrigatório.")]
        [RegularExpression(@"^\d{8,9}$", ErrorMessage = "O número de telefone deve ter exatamente 8 ou 9 dígitos numéricos (ex: 912345678, 46335525).")]
        public string Numero { get; set; }
    }

    public class TelefoneClienteUpdateDto
    {
        public int telefoneId { get; set; }

        [Required(ErrorMessage = "O tipo de telefone é obrigatório.")]
        public string? TipoTelefone { get; set; }

        [Required(ErrorMessage = "O DDD é obrigatório.")]
        [RegularExpression(@"^\d{2}$", ErrorMessage = "O DDD deve ter exatamente 2 dígitos numéricos.")]
        public string? Ddd { get; set; }

        [Required(ErrorMessage = "O número de telefone é obrigatório.")]
        [RegularExpression(@"^\d{8,9}$", ErrorMessage = "O número de telefone deve ter exatamente 8 ou 9 dígitos numéricos (ex: 912345678, 46335525).")]
        public string? Numero { get; set; }
    }

    public class TelefoneClienteCreateDto
    {
        public int ClienteID { get; set; } // Fundamental para o relacionamento.

        [Required(ErrorMessage = "O tipo de telefone é obrigatório.")]
        public string TipoTelefone { get; set; }

        [Required(ErrorMessage = "O DDD é obrigatório.")]
        [RegularExpression(@"^\d{2}$", ErrorMessage = "O DDD deve ter exatamente 2 dígitos numéricos.")]
        public string Ddd { get; set; }

        [Required(ErrorMessage = "O número de telefone é obrigatório.")]
        [RegularExpression(@"^\d{8,9}$", ErrorMessage = "O número de telefone deve ter exatamente 8 ou 9 dígitos numéricos (ex: 912345678, 46335525).")]
        public string Numero { get; set; }
    }
}