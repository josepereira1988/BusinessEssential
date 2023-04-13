using Domain.Entidades.Estado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service.Estado
{
    public interface IMunicipioService
    {
        Task<MunicipioEntity> Get(int id);
        Task<IEnumerable<MunicipioEntity>> GetEntity(MunicipioEntity es);
        Task<IEnumerable<MunicipioEntity>> GetAll();
        Task<MunicipioEntity> Post(MunicipioEntity es);
        Task<MunicipioEntity> Put(MunicipioEntity es);
        Task<bool> Delete(int id);
    }
}
