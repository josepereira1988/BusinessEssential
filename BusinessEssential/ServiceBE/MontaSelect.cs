using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBE
{
    public class MontaSelect
    {
        public static string Queryable(object item)
        {
            int contador = 0;
            string query = "";
            foreach (var i in item.GetType().GetProperties())
            {
                //if (i.Name != "dataTable" && i.Name != "Procurar" && i.Name != "GetKey" && i.Name != "PrimeioRegistro" && i.Name != "UltimoRegistro" && i.Name != "add")
                //{
                //    if (item.GetType().GetProperty(i.Name).GetValue(item) != null && item.GetType().GetProperty(i.Name).GetValue(item) != "")
                //    {
                //        if (i.PropertyType.Name != "Boolean")
                //        {
                //            if (i.PropertyType.Name == "String")
                //            {
                //                if (contador == 0)
                //                {
                //                    query += " where ";
                //                }
                //                if (contador > 0)
                //                    query += " and ";
                //                query += String.Format($" LOWER({i.Name}) Like LOWER('%%{item.GetType().GetProperty(i.Name).GetValue(item)}%%') ");
                //                contador++;
                //            }
                //            else
                //            {
                //                if (i.PropertyType.Name == "Int32")
                //                {
                //                    if (Convert.ToInt32(item.GetType().GetProperty(i.Name).GetValue(item)) > 0)
                //                    {
                //                        if (contador == 0)
                //                        {
                //                            query += " where ";
                //                        }
                //                        if (contador > 0)
                //                            query += " and ";
                //                        query += String.Format($" {i.Name} = '{item.GetType().GetProperty(i.Name).GetValue(item)}' ");
                //                        contador++;
                //                    }
                //                }
                //                else
                //                {
                //                    if (contador == 0)
                //                    {
                //                        query += " where ";
                //                    }
                //                    if (contador > 0)
                //                        query += " and ";
                //                    query += String.Format($" {i.Name} = '{item.GetType().GetProperty(i.Name).GetValue(item)}' ");
                //                    contador++;
                //                }

                //            }
                //        }
                //        else
                //        {
                //            if (Convert.ToBoolean(item.GetType().GetProperty(i.Name).GetValue(item)))
                //            {
                //                if (contador == 0)
                //                {
                //                    query += " where ";
                //                }
                //                if (contador > 0)
                //                    query += " and ";
                //                query += String.Format($" LOWER({i.Name}) = LOWER('%%{item.GetType().GetProperty(i.Name).GetValue(item)}%%') ");
                //                contador++;
                //            }
                //        }


                //    }
                //}
            }

            return query;
        }
    }
}
