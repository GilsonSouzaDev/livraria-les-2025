using System.ComponentModel.DataAnnotations;

namespace livraria_api.api.UI.DTOs
{
    public class CartaoCreditoClienteCreateDto
    {
      
        public int ClienteID { get; set; }

        [Required(ErrorMessage = "A escolha da bandeira é obrigatória.")]
        public int BandeiraID { get; set; }

        [Required(ErrorMessage = "O Número do Cartão é obrigatório.")]
        [RegularExpression(@"^\d{13,19}$", ErrorMessage = "Número do Cartão deve conter entre 13 e 19 dígitos.")]
        public string NumeroCartao { get; set; }

        [Required(ErrorMessage = "O Nome no Cartão é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "Nome no Cartão deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string NomeNoCartao { get; set; }

        [Required(ErrorMessage = "O Código de Segurança é obrigatório.")]
        [RegularExpression(@"^\d{3,4}$", ErrorMessage = "Código de Segurança deve conter 3 ou 4 dígitos.")]
        public string CodigoSeguranca { get; set; }

        public bool Preferencial { get; set; }
    }

    public class CartaoCreditoClienteDto
    {
        public int Id { get; set; }

        public int ClienteID { get; set; }

        [Required(ErrorMessage = "A escolha da bandeira é obrigatória.")]
        public int BandeiraID { get; set; }

        [Required(ErrorMessage = "O Número do Cartão é obrigatório.")]
        [RegularExpression(@"^\d{13,19}$", ErrorMessage = "Número do Cartão deve conter entre 13 e 19 dígitos.")]
        public string NumeroCartao { get; set; }

        [Required(ErrorMessage = "O Nome no Cartão é obrigatório.")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "Nome no Cartão deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string NomeNoCartao { get; set; }

        [Required(ErrorMessage = "O Código de Segurança é obrigatório.")]
        [RegularExpression(@"^\d{3,4}$", ErrorMessage = "Código de Segurança deve conter 3 ou 4 dígitos.")]
        public string CodigoSeguranca { get; set; }

        [Required(ErrorMessage = "O campo Preferencial é obrigatório.")]
        public bool Preferencial { get; set; }

        public BandeiraCartaoDto Bandeira { get; set; }
    }

    public class CartaoCreditoClienteUpdateDto
    {
        [Required(ErrorMessage = "A escolha da bandeira é obrigatória.")]
        public int? BandeiraID { get; set; }

        [RegularExpression(@"^\d{13,19}$", ErrorMessage = "Número do Cartão deve conter entre 13 e 19 dígitos.")]
        public string? NumeroCartao { get; set; }

        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]{3,100}$", ErrorMessage = "Nome no Cartão deve conter apenas letras e espaços, entre 3 e 100 caracteres.")]
        public string? NomeNoCartao { get; set; }

        [RegularExpression(@"^\d{3,4}$", ErrorMessage = "Código de Segurança deve conter 3 ou 4 dígitos.")]
        public string? CodigoSeguranca { get; set; }

        public bool? Preferencial { get; set; }
    }
}
