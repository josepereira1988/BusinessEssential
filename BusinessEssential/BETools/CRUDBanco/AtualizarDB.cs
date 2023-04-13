using DBBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETools.CRUDBanco
{
    internal class AtualizarDB
    {
        //public List<TBEntity> TBEntity { get; set; }
        //public List<CPEntity> CPEntity { get; set; }
        //public List<CPBanco> CPBanco { get; set; }
        //private string query;


        //private string Query()
        //{
        //    query = "";

        //    foreach (var entity in TBEntity)
        //    {

        //        var cb = CPBanco.Where(p => p.TABLE_NAME.Equals(entity.tabela)).ToList();
        //        if (cb.Count > 0)
        //        {

        //        }
        //        else
        //        {
        //            CreateTable createTable = new CreateTable();
        //            //createTable.CPBanco = CPBanco.Where(p => p.TABLE_NAME.Equals(entity.tabela)).ToList();
        //            //createTable.TBEntity = TBEntity.Where(p => p.tabela.Equals(entity.tabela)).ToList();
        //            createTable.CPEntity = CPEntity.Where(p => p.NomeTabela.Equals(entity.tabela)).ToList();
        //            query += createTable.Query(entity.tabela);
        //        }
        //    }
        //    return query;
        //}
        //public void Executar(int idTabela)
        //{
        //    CRUD crud = new CRUD();
        //    crud.DB = EnunDB.config;
        //    var dt = crud.SelectDT("SELECT * FROM octa");
        //    List<TBEntity> tb = new List<TBEntity>();
        //    List<CPEntity> cp = new List<CPEntity>();
        //    List<CPBanco> cb = new List<CPBanco>();

        //    else
        //    {
        //        return;
        //    }
        //    dt = crud.SelectDT($"SELECT * FROM beconfig.cta1");
        //    if (dt.Rows.Count > 0)
        //    {
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            CPEntity cp1 = new CPEntity();
        //            cp1.NomeTabela = dr["NomeTabela"].ToString();
        //            cp1.NomeCampo = dr["NomeCampo"].ToString();
        //            cp1.Primarikey = Convert.ToBoolean(dr["Primarikey"]);
        //            cp1.NTNulo = Convert.ToBoolean(dr["NTNulo"]);
        //            cp1.Autol = Convert.ToBoolean(dr["AutoI"]);
        //            cp1.Tipo = dr["Tipo"].ToString();
        //            cp1.Tamanho = Convert.ToInt32(dr["Tamanho"]);
        //            cp1.Unico = Convert.ToBoolean(dr["Unico"]);
        //            cp1.CHEstran = Convert.ToBoolean(dr["CHEstran"]);
        //            cp1.CPEstran = dr["CPEstran"].ToString();
        //            cp1.TBEstran = dr["TBEstran"].ToString();
        //            cp.Add(cp1);
        //        }
        //    }
        //    dt = crud.SelectDT($"SELECT  TABLE_NAME,COLUMN_NAME,IS_NULLABLE,DATA_TYPE,IFNULL(CHARACTER_MAXIMUM_LENGTH,'0') AS 'CHARACTER_MAXIMUM_LENGTH',COLUMN_KEY,EXTRA " +
        //        $"FROM information_schema.`COLUMNS` where table_schema = (SELECT Banco FROM beconfig.CADASTROSDB WHERE id = {idTabela});");

        //    if (dt.Rows.Count > 0)
        //    {
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            bool nullable;
        //            if (dr["IS_NULLABLE"].ToString() == "NO")
        //            {
        //                nullable = false;
        //            }
        //            else
        //            {
        //                nullable = true;
        //            }
        //            CPBanco cb1 = new CPBanco();
        //            cb1.TABLE_NAME = dr["TABLE_NAME"].ToString();
        //            cb1.COLUMN_NAME = dr["COLUMN_NAME"].ToString();
        //            cb1.IS_NULLABLE = nullable;
        //            cb1.DATA_TYPE = Convert.ToString(dr["DATA_TYPE"]);
        //            cb1.CHARACTER_MAXIMUM_LENGTH = Convert.ToInt32(dr["CHARACTER_MAXIMUM_LENGTH"]);
        //            cb1.COLUMN_KEY = Convert.ToString(dr["COLUMN_KEY"]);
        //            cb1.EXTRA = Convert.ToString(dr["EXTRA"]);
        //            cb.Add(cb1);
        //        }
        //    }
        //    else
        //    {
        //        return;
        //    }
        //    CPBanco = cb;
        //    CPEntity = cp;
        //    TBEntity = tb;
        //    string query = $"use {banco.Rows[0][0].ToString()}; {Query()}";
        //    crud.Crieate(query);
        //}
    }
}
