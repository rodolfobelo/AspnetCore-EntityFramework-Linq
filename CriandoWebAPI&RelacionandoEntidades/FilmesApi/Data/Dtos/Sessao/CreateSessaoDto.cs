using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos.Sessao;


public class CreateSessaoDto
{
    [Required]
    public int FilmeId { get; set; }
    [Required(ErrorMessage = "Nome da sessao é obrigatória.")]
    public string Nome { get; set; }
}