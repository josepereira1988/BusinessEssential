using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades.ListaPreço
{
    public class LinhaPrecoEntity
    {
        public int ID { get; set; }
        public int Linha { get; set; }
        public int CodProd { get; set; }
        public decimal Preco { get; set; }
    }
}
