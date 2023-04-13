using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades.Estado
{
    [Table("OECE")]
    public class EstadoEntity : BaseEntity
    {
        public int IDPais { get; set; }
        [StringLength(2, ErrorMessage = "UF deve ter no máximo {1} de caracteres.")]
        public string UF { get; set; }
        [StringLength(100, ErrorMessage = "Nome deve ter no máximo {1} de caracteres.")]
        public string Nome { get; set; }
        public int? IBGE { get; set; }
    }
}
