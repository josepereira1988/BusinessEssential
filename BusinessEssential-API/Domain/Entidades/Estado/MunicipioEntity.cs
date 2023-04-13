using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades.Estado
{
    [Table("OECM")]
    public class MunicipioEntity : BaseEntity
    {
        public int IDEstado { get; set; }
        [StringLength(100, ErrorMessage = "Municio deve ter no máximo {1} de caracteres.")]
        public string Nome { get; set; }
        public int? IBGE { get; set; }
    }
}
