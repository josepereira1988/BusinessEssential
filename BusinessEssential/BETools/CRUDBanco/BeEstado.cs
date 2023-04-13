using DBBE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETools.CRUDBanco
{
    internal class BeEstado
    {
        public static void executar(string NomeDataBase, CRUD crud)
        {
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('1','AC','Acre','1','12');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('2','AL','Alagoas','1','27');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('3','AM','Amazonas','1','13');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('4','AP','Amapá','1','16');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('5','BA','Bahia','1','29');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('6','CE','Ceará','1','23');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('7','DF','Distrito Federal','1','53');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('8','ES','Espírito Santo','1','32');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('9','GO','Goiás','1','52');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('10','MA','Maranhão','1','21');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('11','MG','Minas Gerais','1','31');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('12','MS','Mato Grosso do Sul','1','50');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('13','MT','Mato Grosso','1','51');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('14','PA','Pará','1','15');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('15','PB','Paraíba','1','25');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('16','PE','Pernambuco','1','26');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('17','PI','Piauí','1','22');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('18','PR','Paraná','1','41');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('19','RJ','Rio de Janeiro','1','33');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('20','RN','Rio Grande do Norte','1','24');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('21','RO','Rondônia','1','11');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('22','RR','Roraima','1','14');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('23','RS','Rio Grande do Sul','1','43');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('24','SC','Santa Catarina','1','42');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('25','SE','Sergipe','1','28');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('26','SP','São Paulo','1','35');");
            crud.Crieate($"Use {NomeDataBase}; INSERT beestado (id,UF,Nome,IdPais,CodigoIBGE) VALUES  ('27','TO','Tocantins','1','17');");




        }
    }
}
