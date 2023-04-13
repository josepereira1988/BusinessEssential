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
    public class TBInfo
    {
        public List<TBEntity> TBEntity;
        public void executar()
        {
            TBEntity = new List<TBEntity>();
            CRUD crud = new CRUD();
            crud.DB = EnunDB.config;
            var dt = crud.SelectDT($"SELECT * FROM OCTA");
            //var banco = crud.SelectDT($"SELECT Banco FROM beconfig.cadastrosdb WHERE id = {idTabela}");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    TBEntity tb1 = new TBEntity();
                    tb1.NomeTabela = dr["NomeTabela"].ToString();
                    tb1.TbFilho = Convert.ToBoolean(dr["TbFilho"]);
                    tb1.TbPai = dr["TbPai"].ToString();
                    tb1.DelCas = Convert.ToBoolean(dr["DelCas"]);
                    TBEntity.Add(tb1);
                }
            }
        }
    }
}
