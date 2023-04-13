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
    public class PaisService : IPaisService
    {
        private IRepository<PaisEntity> _repository;
        private IMapper _mapper;
        public PaisService(IRepository<PaisEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public Task<bool> Delete(int id)
        {
            return _repository.DeleteAsync(id);
        }

        public Task<PaisEntity> Get(int id)
        {
            return _repository.SelectAsync(id);
        }

        public Task<IEnumerable<PaisEntity>> GetAll()
        {
            return _repository.SelectAsync();
        }

        public Task<IEnumerable<PaisEntity>> GetEntity(PaisEntity es)
        {
            return _repository.SelectEntity(es);
        }

        public Task<PaisEntity> Post(PaisEntity es)
        {
            return _repository.InsertAsync(es);
        }

        public Task<PaisEntity> Put(PaisEntity es)
        {
            return _repository.UpdateAsync(es);
        }
    }
}
