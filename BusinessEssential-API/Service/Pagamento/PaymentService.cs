using AutoMapper;
using Domain.Entidades.Pagamento;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Pagamento
{
    public class PaymentService : IPaymentService
    {
        private IPaymentRepository _repository;
        private readonly IMapper _mapper;
        public PaymentService(IPaymentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<PaymentEntity> Get(int id)
        {
            try
            {
                var resultado = await _repository.SelectAsync(id);
                //return new UserDto();
                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<PaymentEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<IEnumerable<PaymentEntity>> GetEntity(PaymentEntity pagamento)
        {
           return await _repository.SelectEntity(pagamento);
        }

        public async Task<PaymentEntity> Post(PaymentEntity pagamento)
        {
            return await _repository.InsertAsync(pagamento);
        }

        public async Task<PaymentEntity> Put(PaymentEntity pagamento)
        {
            return await _repository.UpdateAsync(pagamento);
        }
    }
}
