using Domain.Entidades.Estado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service.Estado
{
    public interface IPaisService
    {
        Task<PaisEntity> Get(int id);
        Task<IEnumerable<PaisEntity>> GetEntity(PaisEntity es);
        Task<IEnumerable<PaisEntity>> GetAll();
        Task<PaisEntity> Post(PaisEntity es);
        Task<PaisEntity> Put(PaisEntity es);
        Task<bool> Delete(int id);
    }
}
