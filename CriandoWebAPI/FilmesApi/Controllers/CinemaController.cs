using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos.Cinema;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    public class CinemaController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;
        public CinemaController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarCinema([FromBody]CreateCinemaDto cinemaDto)
        {
            Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
            return Ok(cinema);
            //return CreatedAtAction(nameof)
        }
    }
}
