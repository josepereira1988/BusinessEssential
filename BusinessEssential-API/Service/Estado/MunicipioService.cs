using AutoMapper;
using Domain.Entidades.Estado;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service.Estado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Estado
{
    public class MunicipioService : IMunicipioService
    {
        private IRepository<MunicipioEntity> _repository;
        private IMapper _mapper;
        public MunicipioService(IRepository<MunicipioEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<bool> Delete(int id)
        {
            return _repository.DeleteAsync(id);
        }

        public Task<MunicipioEntity> Get(int id)
        {
            return _repository.SelectAsync(id);
        }

        public Task<IEnumerable<MunicipioEntity>> GetAll()
        {
            return _repository.SelectAsync();
        }

        public Task<IEnumerable<MunicipioEntity>> GetEntity(MunicipioEntity es)
        {
            return _repository.SelectEntity(es);
        }

        public Task<MunicipioEntity> Post(MunicipioEntity es)
        {
            return _repository.InsertAsync(es);
        }

        public Task<MunicipioEntity> Put(MunicipioEntity es)
        {
            return _repository.UpdateAsync(es);
        }
    }
}
