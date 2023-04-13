using Domain.Entidades.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IPaymentRepository
    {
        Task<PaymentEntity> InsertAsync(PaymentEntity item);
        Task<PaymentEntity> UpdateAsync(PaymentEntity item);
        Task<bool> DeleteAsync(int id);
        Task<PaymentEntity> SelectAsync(int id);
        Task<IEnumerable<PaymentEntity>> SelectAsync();
        Task<List<PaymentEntity>> SelectEntity(PaymentEntity item);
        Task<bool> ExistAsync(int id);
    }
}
