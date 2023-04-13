using Domain.Entidades.Usuarios;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface ILoginRepository
    {
        Task<UserEntity> FindByLogin(string Usuario);
    }
}
