using Consulta.CNPJ.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesBE
{
    public class ConsultarCNPJ
    {
        public InfoCNPJ Consultar(string CNPJ)
        {
            try
            {
                CNPJ = FormatCNPJCPF.SemFormatacao(CNPJ);
                CNPJService service = new CNPJService();
                var resultado = service.ConsultarCPNJ(CNPJ);
                BasesBE.InfoCNPJ info = new BasesBE.InfoCNPJ();
                //info.AtividadeEconomicaSecundaria = resultado.AtividadesSecundarias;
                // info.AtividadeEconomicaPrimaria = resultado.AtividadePrincipal;
                info.DataSituacaoCadastral = resultado.DataSituacao;
                info.EnderecoCEP = resultado.Cep;
                info.EnderecoComplemento = resultado.Municipio;
                info.EnderecoEstado = resultado.Uf;
                info.EnderecoLogradouro = resultado.Logradouro;
                info.EnderecoNumero = resultado.Numero;
                info.MotivoSituacaoCadastral = resultado.MotivoSituacao;
                info.NaturezaJuridica = resultado.NaturezaJuridica;
                info.NomeFantasia = resultado.Fantasia;
                info.RazaoSocial = resultado.Nome;
                info.SituacaoCadastral = resultado.Situacao;
                info.Email = resultado.Email;
                return info;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
