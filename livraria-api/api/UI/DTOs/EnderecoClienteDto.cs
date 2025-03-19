using System.ComponentModel.DataAnnotations;

namespace livraria_api.api.UI.DTOs
{
    public class EnderecoClienteDto
    {
        public int enderedoId { get; set; }
        public int ClienteID { get; set; }
        [Required(ErrorMessage = "O NomeEndereco é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "NomeEndereco deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string NomeEndereco { get; set; }

        [Required(ErrorMessage = "O TipoResidencia é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,50}$", ErrorMessage = "TipoResidencia deve conter apenas letras e espaços, entre 3 e 50 caracteres.")]
        public string TipoResidencia { get; set; }

        [Required(ErrorMessage = "O TipoLogradouro é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,50}$", ErrorMessage = "TipoLogradouro deve conter apenas letras e espaços, entre 3 e 50 caracteres.")]
        public string TipoLogradouro { get; set; }

        [Required(ErrorMessage = "O Logradouro é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ0-9\s]{3,150}$", ErrorMessage = "Logradouro deve conter letras, números e espaços, entre 3 e 150 caracteres.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O Número é obrigatório.")]
        [RegularExpression(@"^(\d{1,10}|S/N)$", ErrorMessage = "Número deve conter apenas números (máx. 10 dígitos) ou 'S/N'.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "Bairro deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "CEP deve estar no formato 99999-999.")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "A Cidade é obrigatória.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "Cidade deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Estado é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{2,100}$", ErrorMessage = "Estado deve conter apenas letras e espaços, entre 2 e 100 caracteres.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O País é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "País deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string Pais { get; set; }
        public string Observacoes { get; set; }
        public bool? UsoCobranca { get; set; }
    }

    public class EnderecoClienteCreateDto
    {
        public int ClienteID { get; set; }
        [Required(ErrorMessage = "O NomeEndereco é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "NomeEndereco deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string NomeEndereco { get; set; }

        [Required(ErrorMessage = "O TipoResidencia é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,50}$", ErrorMessage = "TipoResidencia deve conter apenas letras e espaços, entre 3 e 50 caracteres.")]
        public string TipoResidencia { get; set; }

        [Required(ErrorMessage = "O TipoLogradouro é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,50}$", ErrorMessage = "TipoLogradouro deve conter apenas letras e espaços, entre 3 e 50 caracteres.")]
        public string TipoLogradouro { get; set; }

        [Required(ErrorMessage = "O Logradouro é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ0-9\s]{3,150}$", ErrorMessage = "Logradouro deve conter letras, números e espaços, entre 3 e 150 caracteres.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O Número é obrigatório.")]
        [RegularExpression(@"^(\d{1,10}|S/N)$", ErrorMessage = "Número deve conter apenas números (máx. 10 dígitos) ou 'S/N'.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "Bairro deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "CEP deve estar no formato 99999-999.")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "A Cidade é obrigatória.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "Cidade deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Estado é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{2,100}$", ErrorMessage = "Estado deve conter apenas letras e espaços, entre 2 e 100 caracteres.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O País é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "País deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string Pais { get; set; }
        public string Observacoes { get; set; }
        public bool? UsoCobranca { get; set; }
    }


    public class EnderecoClienteUpdateDto
    {
        public int enderecoId { get; set; }
        [Required(ErrorMessage = "O NomeEndereco é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "NomeEndereco deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string NomeEndereco { get; set; }

        [Required(ErrorMessage = "O TipoResidencia é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,50}$", ErrorMessage = "TipoResidencia deve conter apenas letras e espaços, entre 3 e 50 caracteres.")]
        public string TipoResidencia { get; set; }

        [Required(ErrorMessage = "O TipoLogradouro é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,50}$", ErrorMessage = "TipoLogradouro deve conter apenas letras e espaços, entre 3 e 50 caracteres.")]
        public string TipoLogradouro { get; set; }

        [Required(ErrorMessage = "O Logradouro é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ0-9\s]{3,150}$", ErrorMessage = "Logradouro deve conter letras, números e espaços, entre 3 e 150 caracteres.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O Número é obrigatório.")]
        [RegularExpression(@"^(\d{1,10}|S/N)$", ErrorMessage = "Número deve conter apenas números (máx. 10 dígitos) ou 'S/N'.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "Bairro deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "CEP deve estar no formato 99999-999.")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "A Cidade é obrigatória.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "Cidade deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Estado é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{2,100}$", ErrorMessage = "Estado deve conter apenas letras e espaços, entre 2 e 100 caracteres.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O País é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "País deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string Pais { get; set; }
        public string? Observacoes { get; set; }
        public bool? UsoCobranca { get; set; }
    }
}