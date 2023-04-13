using AutoMapper;
using Domain.Dtos.Usuario;
using Domain.Entidades.Usuarios;

namespace CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDto, UserEntity>().ReverseMap();
        }
    }
}
