using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBE
{
    public class Logadouro
    {
        public Logadouro()
        {
           
        }
        private DataTableQuery dt;
        public DataTable Pais()
        {
            dt = new DataTableQuery("SELECT * FROM bepais");
            return dt.Item;
        }
        public DataTable Municipio()
        {
            dt = new DataTableQuery("SELECT * FROM bemunicipi");
            return dt.Item;
        }
        public DataTable Estado()
        {
            dt = new DataTableQuery("SELECT * FROM beestado");
            return dt.Item;
        }
    }
}
