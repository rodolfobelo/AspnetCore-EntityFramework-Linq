using AutoMapper;
using FilmesApi.Data.Dtos.Cinema;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>();
        CreateMap<Cinema, UpdateCinemaDto>();
        //CreateMap<UpdateCinemaDto, Cinema>();
    }
}
