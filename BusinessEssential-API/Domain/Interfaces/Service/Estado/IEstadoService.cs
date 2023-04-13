using Domain.Entidades.Estado;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service.Estado
{
    public interface IEstadoService
    {
        Task<EstadoEntity> Get(int id);
        Task<IEnumerable<EstadoEntity>> GetEntity(EstadoEntity es);
        Task<IEnumerable<EstadoEntity>> GetAll();
        Task<EstadoEntity> Post(EstadoEntity es);
        Task<EstadoEntity> Put(EstadoEntity es);
        Task<bool> Delete(int id);
    }
}
