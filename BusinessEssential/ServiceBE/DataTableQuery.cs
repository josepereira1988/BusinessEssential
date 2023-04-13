using DBBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBE
{
    public class DataTableQuery
    {
        private CRUD crud;
        public DataTable Item;
        private string query;
        public DataTableQuery(string Query)
        {
            try
            {
                crud = new CRUD();
                crud.DB = EnunDB.DBBase;
                query = Query;
                Execute();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void Execute()
        {
            try
            {
                Item = crud.SelectDT(query);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
