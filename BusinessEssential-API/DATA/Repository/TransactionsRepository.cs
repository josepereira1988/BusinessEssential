using MySql.Data.MySqlClient;
using System;

namespace DATA.Repository
{
    public class TransactionsRepository
    {

        public TransactionsRepository(int obj, int ID, string op)
        {
            DataReaderConect dataReaderConect = new DataReaderConect();
            MySqlDataReader dr = null;
            dr = dataReaderConect.mySqlDataReader($"call dbapi.Transactions('{obj}','{ID}','{op}')");
            if (dr.Read())
            {
                erro = Convert.ToInt32(dr[0]);
                erro_messagem = Convert.ToString(dr[0]);
            }

        }
        public int erro { get; set; }
        public string erro_messagem { get; set; }
    }
}
