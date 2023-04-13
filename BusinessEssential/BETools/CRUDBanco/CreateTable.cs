using BETools.InfoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETools.CRUDBanco
{
    public class CreateTable
    {
        public string Altertable(string tabela)
        {
            string query = "";
            CPInfo CPEntity = new CPInfo();
            CPEntity.executar();
            if(CPEntity.CPEntity.Count > 0)
            {
                foreach(var e in CPEntity.CPEntity.Where(p => p.CHEstran.Equals(true) && p.NomeTabela.Equals(tabela)).ToList())
                {
                    query += $"ALTER TABLE `{tabela}` ADD CONSTRAINT `FK_{tabela}_{e.TBEstran}` FOREIGN KEY(`{e.NomeCampo}`) REFERENCES `{e.TBEstran}` (`{e.CPEstran}`) ON UPDATE NO ACTION ON DELETE NO ACTION; ";
                }
            }            
            return query;

        }
        public string Query(string tabela)
        {
            CPInfo CPEntity = new CPInfo();
            CPEntity.executar();
            int cont = 0;
            string id = "";
            string query = $" CREATE TABLE {tabela} (";
            foreach (var e in CPEntity.CPEntity.Where(p => p.NomeTabela.Equals(tabela)).ToList())
            {
                if (cont > 0)
                    query += ",";
                query += $"{e.NomeCampo} {Tipo(e.Tipo, e.Tamanho)} ";


                if (e.NTNulo)
                {
                    query += "Not NULL ";
                }
                if (e.Unico)
                {
                    query += "UNIQUE ";
                }
                if (e.Autol)
                {
                    query += "AUTO_INCREMENT ";
                }
                cont++;
            }
            cont = 0;
            foreach (var e in CPEntity.CPEntity.Where(p => p.NomeTabela.Equals(tabela) && p.Primarikey.Equals(true)).ToList())
            {
                if (cont > 0)
                {
                    id += ",";
                }
                id += e.NomeCampo;
                cont++;
            }

            if (cont > 0)
            {
                query += $", PRIMARY KEY ({id})";
            }
            cont = 0;
            //foreach (var e in CPEntity.CPEntity.Where(p => p.NomeTabela.Equals(tabela) && p.CHEstran.Equals(true)).ToList())
            //{

            //    query += $",FOREIGN KEY(`{e.NomeCampo}`) REFERENCES `{tabela}` (`{e.NomeCampo}`)";
            //}
            query += "); ";
            return query;
        }
        private string Tipo(string tipo, int tamanho)
        {
            if (tipo == "Varchar")
            {
                return $"Varchar({tamanho})";
            }
            if (tipo == "Preço")
            {
                return $"Decimal({tamanho},2)";
            }
            if (tipo == "Percentaagem")
            {
                return $"Decimal({tamanho},2)";
            }
            if (tipo == "Unidade")
            {
                return $"Decimal({tamanho},2)";
            }
            if (tipo == "BOOLEAN")
            {
                return $"BOOLEAN";
            }
            return "int";
        }
    }
}
