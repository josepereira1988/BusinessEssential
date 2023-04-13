using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETools.Entitys
{
    public class CPEntity
    {
        public string NomeTabela { get; set; }
        public string NomeCampo { get; set; }
        public bool Primarikey { get; set; }
        public bool NTNulo { get; set; }
        public bool Autol { get; set; }
        public string Tipo { get; set; }
        public int Tamanho { get; set; }
        public bool Unico { get; set; }
        public bool CHEstran { get; set; }
        public string CPEstran { get; set; }
        public string TBEstran { get; set; }
        private List<CPEntity> cPEntities;
        public void Executar()
        {

        }
    }
}
