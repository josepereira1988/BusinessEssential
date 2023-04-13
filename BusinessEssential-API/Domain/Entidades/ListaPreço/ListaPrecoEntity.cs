using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades.ListaPreço
{
    public class ListaPrecoEntity : BaseATEntity
    {
        public string Nome { get; set; }
        public string Arredondamento { get; set; }
        public string Moeda { get; set; }
    }
}
