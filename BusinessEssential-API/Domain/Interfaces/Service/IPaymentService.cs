using Domain.Entidades.Pagamento;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IPaymentService
    {
        Task<PaymentEntity> Get(int id);
        Task<IEnumerable<PaymentEntity>> GetEntity(PaymentEntity pagamento);
        Task<IEnumerable<PaymentEntity>> GetAll();
        Task<PaymentEntity> Post(PaymentEntity pagamento);
        Task<PaymentEntity> Put(PaymentEntity pagamento);
        Task<bool> Delete(int id);
    }
}
