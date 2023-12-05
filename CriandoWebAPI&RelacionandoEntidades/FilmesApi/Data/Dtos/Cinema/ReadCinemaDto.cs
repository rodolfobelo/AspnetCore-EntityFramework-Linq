using FilmesApi.Data.Dtos.Endereco;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos.Cinema;

public class ReadCinemaDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public ReadEnderecoDto ReadEnderecoDto { get; set; }
}
