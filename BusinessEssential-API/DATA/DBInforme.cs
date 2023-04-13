using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace DATA
{
    public class DBInforme
    {
        public DBInforme()
        {
            cx = new MySqlConnection();
            cx.ConnectionString = connectionString();
        }
        //public static string arquivo;
        public static string connectionString()
        {
            string connectionString = "";
            DBEntity db = new DBEntity();
            db.DB = ConfigurationManager.AppSettings["DB"].ToString();
            db.IPDB = ConfigurationManager.AppSettings["Servidor"].ToString();
            db.Porta = ConfigurationManager.AppSettings["Porta"].ToString();
            db.SenhaDB = ConfigurationManager.AppSettings["SenhaDB"].ToString();
            db.UsuarioDB = ConfigurationManager.AppSettings["LoginDB"].ToString();
            //if (Environment.MachineName == "DESKTOP-HMSIAUC") 
            //{
            //    connectionString = $"server=localhost;uid=ajc1;pwd=Paraleala09;database=dbapi;port=3306";
            //}
            //else
            //{
            connectionString = $"server={db.IPDB};uid={db.UsuarioDB};pwd={db.SenhaDB};database={db.DB};port={db.Porta}";
            //}               

            return connectionString;
        }
        public MySqlConnection cx;

        public MySqlConnection Conectar()
        {
            try
            {
                if (cx.State == System.Data.ConnectionState.Closed)
                {
                    cx.Open();
                }
                return cx;
            }
            catch (System.Exception ex)
            {
                throw ex;
                return cx;
            }

        }
        public void Desconectar()
        {

            try
            {
                if (cx.State == System.Data.ConnectionState.Open)
                {
                    cx.Close();
                }
                //return Conn;
            }
            catch (System.Exception ex)
            {
                throw ex;
                // MessageBox.Show("Erro ao desconectar banco de dados" + Environment.NewLine + Environment.NewLine + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return Conn;
            }
        }
    }
}
