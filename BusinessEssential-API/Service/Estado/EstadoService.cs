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
    public class EstadoService : IEstadoService
    {
        private IRepository<EstadoEntity> _repository;
        private IMapper _mapper;
        public EstadoService(IRepository<EstadoEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<bool> Delete(int id)
        {
            return _repository.DeleteAsync(id);
        }

        public Task<EstadoEntity> Get(int id)
        {
            return _repository.SelectAsync(id);
        }

        public Task<IEnumerable<EstadoEntity>> GetAll()
        {
            return _repository.SelectAsync();
        }

        public Task<IEnumerable<EstadoEntity>> GetEntity(EstadoEntity es)
        {
            return _repository.SelectEntity(es);
        }

        public Task<EstadoEntity> Post(EstadoEntity es)
        {
            return _repository.InsertAsync(es);
        }

        public Task<EstadoEntity> Put(EstadoEntity es)
        {
            return _repository.UpdateAsync(es);
        }
    }
}
