using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entidades.Pagamento
{
    [Table("PMT1")]
    public class PaymentLinhas
    {
        public int ID { get; set; }
        public PaymentEntity Payment { get; set; }
        public int Linha { get; set; }
        public int Dias { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PParcela { get; set; }
}
}
