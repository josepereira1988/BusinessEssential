using Api.Data.Repository;
using DATA.Context;
using Domain.Entidades.Usuarios;
using Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DATA.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private DbSet<UserEntity> _dataset;
        public LoginRepository(MyContext context)
        {
            _dataset = context.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLogin(string Usuario)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.Usuario.ToLower() == Usuario.ToLower());
        }
    }
}
