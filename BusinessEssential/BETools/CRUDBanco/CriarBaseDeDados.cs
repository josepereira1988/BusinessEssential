using BETools.InfoDb;
using DBBE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETools.CRUDBanco
{
    public class CriarBaseDeDados
    {
        public string NomeDataBase { get; set; }
        public string CNPJ { get; set; }
        public string NomeEmpresa { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public void CriarBase()
        {
            ShowDataBase dataBase = new ShowDataBase();
            dataBase.executar();
            if (dataBase.DataBases.Count > 0)
            {
                if (dataBase.DataBases.Where(p => p.Equals("beconfig")).SingleOrDefault() == "beconfig")
                {
                    if (dataBase.DataBases.Where(p => p.Equals($"{NomeDataBase}")).SingleOrDefault() == null)
                    {
                        string query = "";
                        TBInfo cp = new TBInfo();
                        cp.executar();
                        CRUD crud = new CRUD();
                        crud.DB = EnunDB.config;
                        crud.Crieate($"CREATE DATABASE {NomeDataBase}; ");
                        foreach (var i in cp.TBEntity)
                        {
                            query = $"Use {NomeDataBase}; " + new CreateTable().Query(i.NomeTabela);
                            crud.Crieate(query);
                        }
                        foreach (var i in cp.TBEntity)
                        {
                            string alter = new CreateTable().Altertable(i.NomeTabela);
                            if(alter.Length > 0)
                            {
                                query = $"Use {NomeDataBase}; " + alter;
                                crud.Crieate(query);
                            }
                        }
                        crud.Crieate($"Use beconfig; INSERT cadastrosdb (Banco,Nome,CNPJ,VersaoBase) VALUES ('{NomeDataBase}','{NomeEmpresa}','{CNPJ}','{DBBE.VersaoSistema.versao}');");
                        crud.Crieate($"Use {NomeDataBase}; INSERT beusers (id,Usuario,Nome,Senha,Ativo,Inativo) VALUES ('1','Manager','{NomeUsuario}','{Senha}',True,false);");
                        crud.Crieate($"Use {NomeDataBase}; INSERT beconfig (id,Imposto,Percentage,Preco,Quantidade,Versao) VALUES ('1','2','2','2','2','{DBBE.VersaoSistema.versao}');");
                        crud.Crieate($"Use {NomeDataBase}; INSERT bepais (id,Sigla,CdBacen,Nome) VALUES ('1','BR','1058','Brasil');");
                        //crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,CodigoIBGE) VALUES  ('1','AC','BR','Acre','1058','12'), ('2','AL','BR','Alagoas','1058','27'), ('3','AM','BR','Amazonas','1058','13'), ('4','AP','BR','Amapá','1058','16'), ('5','BA','BR','Bahia','1058','29'), ('6','CE','BR','Ceará','1058','23'), ('7','DF','BR','Distrito Federal','1058','53'), ('8','ES','BR','Espírito Santo','1058','32'), ('9','GO','BR','Goiás','1058','52'), ('10','MA','BR','Maranhão','1058','21'), ('11','MG','BR','Minas Gerais','1058','31'), ('12','MS','BR','Mato Grosso do Sul','1058','50'), ('13','MT','BR','Mato Grosso','1058','51'), ('14','PA','BR','Pará','1058','15'), ('15','PB','BR','Paraíba','1058','25'), ('16','PE','BR','Pernambuco','1058','26'), ('17','PI','BR','Piauí','1058','22'), ('18','PR','BR','Paraná','1058','41'), ('19','RJ','BR','Rio de Janeiro','1058','33'), ('20','RN','BR','Rio Grande do Norte','1058','24'), ('21','RO','BR','Rondônia','1058','11'), ('22','RR','BR','Roraima','1058','14'), ('23','RS','BR','Rio Grande do Sul','1058','43'), ('24','SC','BR','Santa Catarina','1058','42'), ('25','SE','BR','Sergipe','1058','28'), ('26','SP','BR','São Paulo','1058','35'), ('27','TO','BR','Tocantins','1058','17');");
                        BeEstado.executar(NomeDataBase, crud);
                        BeMunicipio.executar(NomeDataBase,crud);
                        
                    }
                    else
                    {
                        throw new Exception($"{NomeDataBase} base já existe");
                    }

                }
                else
                {
                    throw new Exception("beconfig não esta instaldo");
                }
            }
            else
            {
                throw new Exception("Nenhuma base de dados localicada");
            }

        }
        public void UsuarioInicial()
        {

        }
        public void Configurar()
        {

        }
    }
}
