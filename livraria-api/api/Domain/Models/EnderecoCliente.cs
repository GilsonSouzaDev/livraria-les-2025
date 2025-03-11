

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace livraria_api.api.Domain.Models;

public class EnderecoCliente
{
    public int EnderecoId { get; set; }
   

    public int ClienteId { get; set; }

    [Required(ErrorMessage = "O nome do endereço é obrigatório.")]
    public string NomeEndereco { get; set; } = null!;

    [Required(ErrorMessage = "O tipo de residência é obrigatório.")]
    public string TipoResidencia { get; set; } = null!;

    [Required(ErrorMessage = "O tipo de logradouro é obrigatório.")]
    public string TipoLogradouro { get; set; } = null!;

    [Required(ErrorMessage = "O logradouro é obrigatório.")]
    public string Logradouro { get; set; } = null!;

    [Required(ErrorMessage = "O número é obrigatório.")]
    public string Numero { get; set; } = null!;


    public string Bairro { get; set; } = null!;

    [Required(ErrorMessage = "O CEP é obrigatório.")]
    [RegularExpression(@"^\d{5}-?\d{3}$", ErrorMessage = "Formato do CEP inválido. Use o formato 00000-000 ou 00000000.")]
    public string Cep { get; set; } = null!;

    [Required(ErrorMessage = "A cidade é obrigatória.")]
    public string Cidade { get; set; } = null!;

    [RegularExpression(@"^[A-Za-z]{2}$", ErrorMessage = "A sigla do estado deve ter exatamente dois caracteres alfabéticos. ex: SP, MT")]
    public string Estado { get; set; } = null!;

    [Required(ErrorMessage = "O país é obrigatório.")]
    public string Pais { get; set; } = null!;

    public string? Observacoes { get; set; }

    public bool? UsoCobranca { get; set; }

    
    [JsonIgnore]
    public virtual Cliente Cliente { get; set; } = null!;
}

