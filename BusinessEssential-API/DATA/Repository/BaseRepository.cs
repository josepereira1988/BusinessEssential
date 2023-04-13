using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DATA;
using DATA.Context;
using Domain.Entidades;
using Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        private DbSet<T> _dataset;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.ID.Equals(id));
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
            return await _dataset.AnyAsync(p => p.ID.Equals(id));
        }

        public async Task<T> InsertAsync(T item)
        {
            using (var Transaction = _context.Database.BeginTransaction())
            {
                try
                {
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

        public async Task<T> SelectAsync(int id)
        {
            try
            {
                var resultado = await _dataset.SingleOrDefaultAsync(p => p.ID == id) ;
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> SelectEntity(T item)
        {
            int contador = 0;
            var query = "select * from " + _dataset.EntityType.GetTableName() + "" + QueryEntity.Query(item);
            return await _dataset.FromSqlRaw(query).ToListAsync();
        }

        public async Task<T> UpdateAsync(T item)
        {
            using (var Transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var result = await _dataset.SingleOrDefaultAsync(p => p.ID.Equals(item.ID));
                    if (result == null)
                    {
                        return null;
                    }
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
    }
}
