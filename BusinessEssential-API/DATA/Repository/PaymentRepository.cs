using DATA.Context;
using Domain.Entidades.Pagamento;
using Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATA.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        protected readonly MyContext _context;
        private DbSet<PaymentEntity> _dataset;
        public PaymentRepository(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<PaymentEntity>();
        }
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var result = await _dataset.Include(p => p.PaymentLinhas).SingleOrDefaultAsync(p => p.ID.Equals(id));
                if (result == null)
                {
                    return false;
                }

                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _dataset.Include(p => p.PaymentLinhas).AnyAsync(p => p.ID.Equals(id));
        }

        public async Task<PaymentEntity> InsertAsync(PaymentEntity item)
        {
            using (var Transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    item.CreateAt = DateTime.UtcNow;
                    _dataset.Add(item);
                    await _context.SaveChangesAsync();
                    Transaction.Commit();
                }
                catch (Exception ex)
                {
                    Transaction.Rollback();
                    throw ex;
                }
            }

            return item;
        }

        public async Task<PaymentEntity> SelectAsync(int id)
        {
            try
            {
                var resultado = await _dataset.Include(p => p.PaymentLinhas).SingleOrDefaultAsync(p => p.ID == id);
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<PaymentEntity>> SelectAsync()
        {
            try
            {
                var resultado = await _context.PaymentEntity.Include(p => p.PaymentLinhas).ToListAsync();
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<List<PaymentEntity>> SelectEntity(PaymentEntity item)
        {
            
            var query = "select * from " + _dataset.EntityType.GetTableName() + "" + QueryEntity.Query(item);         
            return _dataset.FromSqlRaw(query).ToListAsync();
        }

        public async Task<PaymentEntity> UpdateAsync(PaymentEntity item)
        {
            var result = await _dataset.Include(p => p.PaymentLinhas).SingleOrDefaultAsync(p => p.ID.Equals(item.ID));
            if (result == null)
            {
                return null;
            }
            using (var Transaction = _context.Database.BeginTransaction())
            {
                
                try
                {
                    item.UpdateAt = DateTime.UtcNow;
                    item.CreateAt = result.CreateAt;
                    _context.Entry(result).CurrentValues.SetValues(item);
                    foreach (var f in item.PaymentLinhas)
                    {
                        if(!item.PaymentLinhas.Any(c => c.Linha == f.Linha))
                        {
                            _context.PaymentLinhas.Remove(f);
                        }
                    }
                    foreach(PaymentLinhas f in item.PaymentLinhas)
                    {
                        f.ID = result.ID;
                        var adda = result.PaymentLinhas.Where(p => p.Linha.Equals(f.Linha)).SingleOrDefault();
                        if(adda != null)
                        {
                            _context.Entry(adda).CurrentValues.SetValues(f);
                        }
                        else
                        {
                            _context.PaymentLinhas.Add(f);
                        }
                    }                                       
                    await _context.SaveChangesAsync();
                    //TransactionsRepository transaction = new TransactionsRepository(item.Objtype, item.ID, "U");
                    //if(transaction.erro > 0)
                    //{
                    //    Transaction.Rollback();
                    //    return new PaymentEntity();
                    //}
                    Transaction.Commit();
                    result = await _dataset.Include(p => p.PaymentLinhas).SingleOrDefaultAsync(p => p.ID.Equals(item.ID));
                }
                catch (Exception ex)
                {
                    Transaction.Rollback();
                    throw ex;
                }
            }
            return result;
        }
    }
}
