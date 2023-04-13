using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades.Parceiro_de_Negocio
{
    public class EnderecoPN
    {
        public string Address { get; set; }
        public int IDPN { get; set; }
        public string CE { get; set; }
        public string Logadouro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public int IDPais { get; set; }
        public int IDEstado { get; set; }
        public int IDMunicipio { get; set; }
    }
}
