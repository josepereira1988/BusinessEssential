using DBBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBE
{
    public class BancosDeDados
    {
        public DataTable BancosSistemas()
        {
            CRUD crud = new CRUD();
            var dt = crud.SelectDT("SELECT * FROM beconfig.cadastrosdb");
            return dt;
        }
    }
}
