using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades.Parceiro_de_Negocio
{
    public class ParceiroDeNegocio : BaseObjEntity
    {
        public string Codigo { get; set; }
        public string TipoCod { get; set; }
        public string Sequencia { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string Grupo { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public string Ativo { get; set; }
        public string Inativo { get; set; }
        public string CredLimit { get; set; }
        public string ComproCred { get; set; }
        public string CondPag { get; set; }
        public string Desconto { get; set; }
        public string ListPre { get; set; }
    }
}
