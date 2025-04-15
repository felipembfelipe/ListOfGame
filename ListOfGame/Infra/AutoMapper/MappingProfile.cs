using AutoMapper;
using ListOfGame.Models;
using ListOfGame.Models.DTO;

namespace ListOfGame.Infra.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Game, GameDTO>().ReverseMap();
            CreateMap<StatusGame, StatusGameDTO>().ReverseMap();
        }
    }
}
