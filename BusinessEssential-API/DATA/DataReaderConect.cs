using MySql.Data.MySqlClient;
using System.Data;

namespace DATA
{
    public class DataReaderConect
    {
        public MySqlDataReader mySqlDataReader(string query)
        {
            DBInforme dBInforme = new DBInforme();
            MySqlCommand cmd = new MySqlCommand(query,dBInforme.Conectar());
            MySqlDataReader dr = null;
            try
            {
                dBInforme.Conectar();
                dr = cmd.ExecuteReader();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                dBInforme.Desconectar();
            }
            return dr;
        }
    }
}
