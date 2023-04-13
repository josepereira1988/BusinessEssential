using DBBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBE
{
    public class ConectarService
    {
        private CRUD crud;
        public ConectarService()
        {
            crud = new CRUD();            
        }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int banco { get; set; }
        public bool conectar()
        {
            try
            {
                crud.DB = EnunDB.config;
                var DBBanco = crud.SelectDT($"SELECT * FROM beconfig.cadastrosdb WHERE ID = {banco};");
                if (DBBanco.Rows.Count > 0)
                {
                    NomeBase.DB = DBBanco.Rows[0]["Banco"].ToString();
                    ConexaoDB conexao = new ConexaoDB();
                    var Validar = conexao.SelectDT($"SELECT * FROM beusers WHERE Usuario = '{Usuario}';");
                    if (Validar.Rows.Count > 0)
                    {
                        if (Validar.Rows[0]["Usuario"].ToString().ToLower() == Usuario.ToLower() && BasesBE.Criptografia.Descriptografar(Validar.Rows[0]["Senha"].ToString()) == Senha)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return false;
        }
    }
}
