using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential
{
    public class BEDataGridViewCheckBoxColumn : DataGridViewCheckBoxColumn
    {
        public string Tabela { get { return _Tabela; } set { _Tabela = value;} }
        private string _Tabela { get; set; }
        public string Campo { get { return _Campo; } set { _Campo = value; } }
        private string _Campo;
    }
}
