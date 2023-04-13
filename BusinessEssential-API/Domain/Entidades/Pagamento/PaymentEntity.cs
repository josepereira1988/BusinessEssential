using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entidades.Pagamento
{
    [Table("OPMT")]
    public class PaymentEntity : BaseATEntity
    {
        [StringLength(100, ErrorMessage = "Sigla deve ter no máximo {1} de caracteres.")]
        public string descricao { get; set; }
        public int Qparcelas { get; set; }
        [ForeignKey("ID")]
        public IEnumerable<PaymentLinhas> PaymentLinhas { get; set; }
    }
}
