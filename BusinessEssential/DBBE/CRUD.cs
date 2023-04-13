using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBE
{
    public class CRUD
    {
        public EnunDB DB { get; set; }
        public int Crieate(string query)
        {
            Conexao cx = new(DB);
            MySqlCommand cmd = new();
            int retorno = 0;

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = cx.Conectar();
                cx.Conectar();
                cmd.ExecuteNonQuery();
                retorno = Convert.ToInt32(cmd.LastInsertedId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cx.Desconectar();
                cmd.Dispose();
            }
            return retorno;
        }
        public void Atualizar(string query)
        {
            Conexao cx = new(DB);
            MySqlCommand cmd = new();
            int retorno = 0;
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = cx.Conectar();
                cx.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cx.Desconectar();
                cmd.Dispose();
            }
            //return retorno;
        }
        public DataTable SelectDT(string query)
        {
            DataTable dt = new();
            Conexao conexao = new(DB);
            try
            {
                MySqlCommand cmd = new(query, conexao.Conn);
                conexao.Conectar();
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Desconectar();
            }
            return dt;
        }
    }
}
