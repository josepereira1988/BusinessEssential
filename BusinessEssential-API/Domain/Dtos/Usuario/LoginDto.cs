using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.Usuario
{
    public class LoginDto
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
