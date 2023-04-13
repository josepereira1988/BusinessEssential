using Domain.Dtos.Usuario;
using Domain.Entidades.Usuarios;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IUsersService
    {
        Task<UserDto> Get(int id);
        Task<IEnumerable<UserDto>> GetEntity(UserDto user);
        Task<IEnumerable<UserDto>> GetAll();
        Task<UserEntity> Post(UserDto user);
        Task<UserDto> Put(UserDto user);
        Task<bool> Delete(int id);
    }
}
