using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entidades.Estado
{
    [Table("OECP")]
    public class PaisEntity : BaseEntity
    {
        [StringLength(100, ErrorMessage = "Nome deve ter no máximo {1} de caracteres.")]
        public string Nome { get; set; }
        public int? CdSis { get; set; }
    }
}
