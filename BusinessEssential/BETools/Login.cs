using BasesBE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETools
{
    internal class Login
    {
        public string Servidor { get; set; }
        public string Porta { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int GerarArquivo()
        {
            try
            {
                StringBuilder Config = new StringBuilder();
                string path = System.IO.Directory.GetCurrentDirectory().ToString();
                Config.Append($"{Criptografia.Criptografar(Servidor)};{Criptografia.Criptografar(Porta)};{Criptografia.Criptografar(Usuario)};{Criptografia.Criptografar(Senha)}");
                using (TextWriter textWriter = (TextWriter)new StreamWriter(path + "\\Conexao.cfg", false, Encoding.Default))
                {
                    textWriter.Write(Config.ToString());
                    textWriter.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return 0;
        }
    }
}
