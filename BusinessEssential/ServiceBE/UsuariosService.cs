using DBBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBE
{
    public class UsuariosService
    {
        private ConexaoDB crud;
        public UsuariosService()
        {
            crud = new ConexaoDB();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public bool Inativo { get; set; }
        public const string Tabela = "BeUsers";
        private void dataTable(DataTable dt)
        {
            if(dt.Rows.Count > 0)
            {
                Id = Convert.ToInt32(dt.Rows[0]["id"]);
                Nome = Convert.ToString(dt.Rows[0]["Nome"]);
                Usuario = Convert.ToString(dt.Rows[0]["Usuario"]);
                Senha = Convert.ToString(dt.Rows[0]["Senha"]);
                Ativo = Convert.ToBoolean(dt.Rows[0]["Ativo"].ToString());
                Inativo = Convert.ToBoolean(dt.Rows[0]["Inativo"].ToString());
            }
        }
        public int GetKey(int ID)
        {
            try
            {
                Id = 0;
                string query = $"select * from beusers WHERE id = '{ID}'";
                var dt = crud.SelectDT(query);
                if(dt.Rows.Count > 0)
                {
                    dataTable(dt);
                    Id = Convert.ToInt32(dt.Rows[0][0].ToString());
                }                
                return Id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int PrimeioRegistro()
        {
            try
            {
                Id = 0;
                string query = "SELECT * from beusers ORDER BY id LIMIT 1;";
                var dt = crud.SelectDT(query);
                dataTable(dt);
                return Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UltimoRegistro()
        {
            try
            {
                Id = 0;
                string query = "SELECT * from beusers ORDER BY id DESC LIMIT 1;";
                var dt = crud.SelectDT(query);
                dataTable(dt);
                return Id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int add()
        {            
            var ultimoid = new DataTableQuery("SELECT * from beusers ORDER BY id DESC LIMIT 1;");
            int idadd = Convert.ToInt32(ultimoid.Item.Rows[0][0]) + 1;
            string query = $"INSERT BEUsers (id,Usuario,Nome,Senha,Ativo,Inativo) VALUES ({idadd},'{Usuario}','{Nome}','{Senha}',{Ativo},{Inativo});";
            crud.Crieate(query);
            Id = idadd;
            return idadd;
        }
        public void autalizar()
        {
            try
            {
                string query = $"update BEUsers set Usuario = '{Usuario}',Nome = '{Nome}',Senha = '{Senha}',Ativo = {Ativo},Inativo = {Inativo} where id = '{Id}';";
                crud.Atualizar(query);
                //return idr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
