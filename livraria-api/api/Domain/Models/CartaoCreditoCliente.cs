
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace livraria_api.api.Domain.Models;

public class CartaoCreditoCliente 
{
    public int CartaoCreditoClienteId { get; set; }

    public int ClienteID { get; set; }

    public int BandeiraID { get; set; }

    [Required(ErrorMessage = "O número do cartão é obrigatório.")]
    [StringLength(19, MinimumLength = 13, ErrorMessage = "O número do cartão deve ter entre 13 e 19 dígitos.")]
    public string? NumeroCartao { get; set; }

    [Required(ErrorMessage = "O nome no cartão é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome no cartão deve ter no máximo 100 caracteres.")]
    public string? NomeNoCartao { get; set; }

    [Required(ErrorMessage = "O código de segurança é obrigatório.")]
    [RegularExpression(@"^\d{3,4}$", ErrorMessage = "Código de segurança inválido.Apenas valores numericos aceitos entre 3 à 4 digitos ex:123, 1234 ")]
    public string? CodigoSeguranca { get; set; }
    public bool Preferencial { get; set; }

    // Propriedades de navegação (IMPORTANTES)

    [JsonIgnore]
    public Cliente? Cliente { get; set; }

    [JsonIgnore]
    public BandeiraCartao? Bandeira { get; set; }

}
