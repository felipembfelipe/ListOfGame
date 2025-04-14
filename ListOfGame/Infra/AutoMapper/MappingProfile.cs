using AutoMapper;
using ListOfGame.Models;
using ListOfGame.Models.DTO;

namespace ListOfGame.Infra.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<Game, GameDTO>().ReverseMap();

            CreateMap<TipoStatusGame, TipoStatusGameDTO>().ReverseMap();
            CreateMap<TipoUsuario, TipoUsuarioDTO>().ReverseMap();
        }
    }
}
