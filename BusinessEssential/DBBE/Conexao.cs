using BasesBE;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBE
{
    internal class Conexao
    {
        internal MySqlConnection Conn = new MySqlConnection();
        private string DB { get; set; }
        private string LoginDB { get; set; }
        private string SenhaDB { get; set; }
        private string Servidor { get; set; }
        private string Porta { get; set; }
        internal Conexao(EnunDB enunDB)
        {
            LoginDB = "";
            SenhaDB = "";
            Servidor = "";
            Porta = "";
            if (enunDB == EnunDB.DBBase)
            {
                DB = NomeBase.DB;
            }
            if (enunDB == EnunDB.config)
            {
                DB = "beconfig";
            }
            if (enunDB == EnunDB.master)
            {
                DB = "mysql";
            }
            string Caminho = System.IO.Directory.GetCurrentDirectory().ToString() + "\\Conexao.cfg";
            var salva = Caminho;
            string salvo = Caminho;
            var linhaseparada = File.ReadAllLines(salvo).Select(a => a.Split(';')).ToList();
            foreach (var item in linhaseparada)
            {
                LoginDB = item[2].ToString();
                SenhaDB = item[3].ToString();
                Servidor = item[0].ToString();
                Porta = item[1].ToString();
            }
            Conn.ConnectionString = $"server={Criptografia.Descriptografar(Servidor)}" +
                $";uid={Criptografia.Descriptografar(LoginDB)};" +
                $"pwd={Criptografia.Descriptografar(SenhaDB)};database={DB};" +
                $"port={Criptografia.Descriptografar(Porta)}";
        }
        public MySqlConnection Conectar()
        {
            try
            {
                if (Conn.State == System.Data.ConnectionState.Closed)
                {
                    Conn.Open();
                }
                return Conn;
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show("Erro ao conectar banco de dados" + Environment.NewLine + Environment.NewLine + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }

        }
        public void Desconectar()
        {

            try
            {
                if (Conn.State == System.Data.ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            catch (System.Exception ex)
            {
                // MessageBox.Show("Erro ao desconectar banco de dados" + Environment.NewLine + Environment.NewLine + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return Conn;
            }
        }
    }
}
