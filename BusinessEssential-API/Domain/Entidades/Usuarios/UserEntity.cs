using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entidades.Usuarios
{
    [Table("OUSR")]
    public class UserEntity : BaseATEntity
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public bool Inativo { get; set; }
        public int Departamento { get; set; }        
    }
}
