using System.ComponentModel.DataAnnotations;
using FilmesApi.Models;

namespace FilmesApi.Data.Dtos.Sessao;

public class ReadSessaoDto
{
    public int Id { get; set; }
    [Required]
    public int FilmeId { get; set; }
    [Required(ErrorMessage = "Nome da sessao é obrigatória.")]
    public string Nome { get; set; }
}
