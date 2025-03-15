

using System.ComponentModel.DataAnnotations;

namespace livraria_api.api.Domain.Models;

public class Cliente
{
    public int ClienteId { get; set; }

    [Required(ErrorMessage = "O código do cliente é obrigatório.")]
    [StringLength(20, ErrorMessage = "Código do cliente deve ter no máximo 20 caracteres.")]
    public string? CodigoCliente { get; set; }

    [Required(ErrorMessage = "O gênero é obrigatório.")]
    [StringLength(10, ErrorMessage = "Gênero deve ter no máximo 10 caracteres.")]
    public string? Genero { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(150, ErrorMessage = "Nome deve ter no máximo 150 caracteres.")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
    public string DataNascimento { get; set; }

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    public string? Cpf { get; set; }

    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    public string? Email { get; set; }

    public int? Pontuacao { get; set; }

    public int? Ranking { get; set; }

    public bool? Ativo { get; set; }

    public virtual ICollection<CartaoCreditoCliente> CartoesCreditoClientes { get; set; } = new List<CartaoCreditoCliente>();

    public virtual ICollection<EnderecoCliente> EnderecosClientes { get; set; } = new List<EnderecoCliente>();

    public virtual ICollection<TelefoneCliente> TelefonesClientes { get; set; } = new List<TelefoneCliente>();
}
