using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? DataEvento { get; set; }
        
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Intervalo permitido de 3 a 50 caracteres.")]
        [MinLength(3, ErrorMessage = "{0} deve ter no mínimo 4 caracteres.")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Display(Name = "quantidade_pessoas")]
        [Range(1, 120000, ErrorMessage = "{0}")]
        public int QuantidadePessoas { get; set; }
        
        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$", ErrorMessage ="Não é um formato de imagem válido. (gif, jpg, jpeg, bmp, png).")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Phone(ErrorMessage = "O campo {0} com número inválido.")]
        public string Telefone { get; set; }
        
        [Required(ErrorMessage = "O {0} é obrigatório.")]
        [Display(Name = "e-mail")]
        [EmailAddress(ErrorMessage = "Necessário ser um {0} válido.")]
        public string Email { get; set; }
        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; }
    }
}
