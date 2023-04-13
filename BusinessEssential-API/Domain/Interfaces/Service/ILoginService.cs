using Domain.Dtos.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);
    }
}
