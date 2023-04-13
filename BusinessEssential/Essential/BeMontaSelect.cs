using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential
{
    public class BeMontaSelect
    {
        public static string Queryable(FrmBase item)
        {
            int contador = 0;
            string query = "";
            foreach (var i in item.Controls)
            {
                if(i.GetType() == typeof(TextBoxBE))
                {
                    if(((TextBoxBE)i).Text != "")
                    {
                        if (contador == 0)
                        {
                            query += " where ";
                        }
                        if (contador > 0)
                            query += " and ";
                        query += String.Format($" LOWER({((TextBoxBE)i).Campo}) Like LOWER('%%{((TextBoxBE)i).Text}%%') ");
                        contador++;
                    }
                }
            }
                return query;
        }
    }
}
