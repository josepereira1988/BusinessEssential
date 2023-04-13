using DBBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETools.InfoDb
{
    public class ShowDataBase
    {
        public List<string> DataBases { get; set; }
        public void executar()
        {
            CRUD crud = new CRUD();
            crud.DB = EnunDB.master;
            DataBases = new List<string>();
            var dt = crud.SelectDT("SELECT  SCHEMA_NAME FROM information_schema.SCHEMATA");
            foreach(DataRow dr in dt.Rows)
            {
                DataBases.Add(dr[0].ToString());
            }
        }
    }
}
