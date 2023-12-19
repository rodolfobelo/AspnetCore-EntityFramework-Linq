using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;
[ApiController]
[Route("[controller]")]
public class SessaoController : ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;
    public SessaoController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarSessao(CreateSessaoDto dto)
    {
        Sessao sessao = _mapper.Map<Sessao>(dto);
        _context.Sessoes.Add(sessao);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarSessoesPorId), new {Id = sessao.Id}, sessao);
    }

    [HttpGet]
    public IEnumerable<ReadSessaoDto> RecuperarSessoes()
    {
        return _mapper.Map<List<ReadSessaoDto>>(_context.Sessoes.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarSessoesPorId(int id)
    {
        Sessao sessao = _context.Sessoes.FirstOrDefault(s => s.Id == id);
        if (sessao != null)
        {
            ReadSessaoDto readSessaoDto = _mapper.Map<ReadSessaoDto>(sessao);
            return Ok(readSessaoDto);
        }
        return NotFound();
    }
}
