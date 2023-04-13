using BETools.Entitys;
using DBBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETools.InfoDb
{
    public class CPInfo
    {
        public List<CPEntity> CPEntity;
        public void executar()
        {
            CPEntity = new List<CPEntity>();
            CRUD crud = new CRUD();
            crud.DB = EnunDB.config;
            var dt = crud.SelectDT($"SELECT t0.*,(SELECT t1.NomeTabela FROM octa t1 WHERE t0.idTabela = t1.Id) AS 'NomeTabela',(SELECT t1.NomeTabela FROM octa t1 WHERE t0.TBEstran = t1.Id) AS 'TbNEstran' FROM beconfig.cta1 t0 order by idTabela,CPid");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    CPEntity cp1 = new CPEntity();
                    cp1.NomeTabela = dr["NomeTabela"].ToString();
                    cp1.NomeCampo = dr["NomeCampo"].ToString();
                    cp1.Primarikey = Convert.ToBoolean(dr["Primarikey"]);
                    cp1.NTNulo = Convert.ToBoolean(dr["NTNulo"]);
                    cp1.Autol = Convert.ToBoolean(dr["AutoI"]);
                    cp1.Tipo = dr["Tipo"].ToString();
                    cp1.Tamanho = Convert.ToInt32(dr["Tamanho"]);
                    cp1.Unico = Convert.ToBoolean(dr["Unico"]);
                    cp1.CHEstran = Convert.ToBoolean(dr["CHEstran"]);
                    cp1.CPEstran = dr["CPEstran"].ToString();
                    cp1.TBEstran = dr["TbNEstran"].ToString();
                    CPEntity.Add(cp1);
                }
            }
        }
    }
}
