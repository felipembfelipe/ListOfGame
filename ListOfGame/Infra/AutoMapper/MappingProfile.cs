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
        }
    }
}
