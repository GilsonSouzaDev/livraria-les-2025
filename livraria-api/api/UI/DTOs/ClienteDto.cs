using System.ComponentModel.DataAnnotations;

namespace livraria_api.api.UI.DTOs
{
    public class ClienteDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo CodigoCliente é obrigatório.")]
        [RegularExpression(@"^[A-Za-z0-9]{5,20}$", ErrorMessage = "CodigoCliente deve conter apenas letras e números, com 5 a 20 caracteres.")]
        public string CodigoCliente { get; set; }

        [Required(ErrorMessage = "O campo Genero é obrigatório.")]
        [RegularExpression(@"^(M|F)$", ErrorMessage = "O campo Genero deve ser 'M' para masculino ou 'F' para feminino.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "Nome deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo DataNascimento é obrigatório.")]
        public string DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF deve estar no formato 999.999.999-99.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [RegularExpression(@"^[\w\.-]+@[a-zA-Z\d.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email deve estar em um formato válido.")]
        public string Email { get; set; }
        public int? Ranking { get; set; }
        public int? Pontuacao { get; set; }
        public bool Ativo { get; set; }
    }

    public class ClienteUpdateDto
    {
        [Required(ErrorMessage = "O campo CodigoCliente é obrigatório.")]
        [RegularExpression(@"^[A-Za-z0-9]{5,20}$", ErrorMessage = "CodigoCliente deve conter apenas letras e números, com 5 a 20 caracteres.")]
        public string? CodigoCliente { get; set; }

        [Required(ErrorMessage = "O campo Genero é obrigatório.")]
        [RegularExpression(@"^(Masculino|Feminino|Outro)$", ErrorMessage = "Genero deve ser 'Masculino', 'Feminino' ou 'Outro'.")]
        public string? Genero { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "Nome deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo DataNascimento é obrigatório.")]
        public string? DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF deve estar no formato 999.999.999-99.")]
        public string? CPF { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [RegularExpression(@"^[\w\.-]+@[a-zA-Z\d.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email deve estar em um formato válido.")]
        public string? Email { get; set; }

        public int? Pontuacao { get; set; }
        public int? Ranking { get; set; }
        public bool? Ativo { get; set; }
    }

    public class ClienteCreateDto
    {

        [Required(ErrorMessage = "O campo CodigoCliente é obrigatório.")]
        [RegularExpression(@"^[A-Za-z0-9]{5,20}$", ErrorMessage = "CodigoCliente deve conter apenas letras e números, com 5 a 20 caracteres.")]
        public string CodigoCliente { get; set; }

        [Required(ErrorMessage = "O campo Genero é obrigatório.")]
        [RegularExpression(@"^(Masculino|Feminino|Outro)$", ErrorMessage = "Genero deve ser 'Masculino', 'Feminino' ou 'Outro'.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "Nome deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo DataNascimento é obrigatório.")]
        public string DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF deve estar no formato 999.999.999-99.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [RegularExpression(@"^[\w\.-]+@[a-zA-Z\d.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email deve estar em um formato válido.")]
        public string Email { get; set; }

        public int? Pontuacao { get; set; }
        public int? Ranking { get; set; }
        public bool Ativo { get; set; }

        public List<EnderecoClienteCreateDto> EnderecosClientes { get; set; }
        public List<TelefoneClienteCreateDto> TelefonesClientes { get; set; }

    }

    public class ClienteCompletoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo CodigoCliente é obrigatório.")]
        [RegularExpression(@"^[A-Za-z0-9]{5,20}$", ErrorMessage = "CodigoCliente deve conter apenas letras e números, com 5 a 20 caracteres.")]
        public string CodigoCliente { get; set; }

        [Required(ErrorMessage = "O campo Genero é obrigatório.")]
        [RegularExpression(@"^(Masculino|Feminino|Outro)$", ErrorMessage = "Genero deve ser 'Masculino', 'Feminino' ou 'Outro'.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "Nome deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo DataNascimento é obrigatório.")]
        public string DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF deve estar no formato 999.999.999-99.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [RegularExpression(@"^[\w\.-]+@[a-zA-Z\d.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email deve estar em um formato válido.")]
        public string Email { get; set; }

        public int? Pontuacao { get; set; }
        public int? Ranking { get; set; }
        public bool Ativo { get; set; }

        public List<EnderecoClienteDto> Enderecos { get; set; }
        public List<TelefoneClienteDto> Telefones { get; set; }
        public List<CartaoCreditoClienteDto> Cartoes { get; set; }
    }

}
