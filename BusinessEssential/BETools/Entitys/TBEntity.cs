using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETools.Entitys
{
    public class TBEntity
    {
        public string NomeTabela { get; set; }
        public bool TbFilho { get; set; }
        public string TbPai { get; set; }
        public bool DelCas { get; set; }
    }
}
