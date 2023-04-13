using ServiceBE;
using System.Data;

namespace Essential
{
    public class BEDataGridViewTextBoxColumn : DataGridViewTextBoxColumn
    {
        public BEDataGridViewTextBoxColumn()
        {

        }
        public string Tabela { get { return _Tabela; } set { _Tabela = value; config(); } }
        private string _Tabela { get; set; }
        public string Campo { get { return _Campo; } set { _Campo = value; config(); } }
        private string _Campo;
        private void config()
        {
            if (Tabela != null && Tabela != "" && _Campo != null && _Campo != "")
            {
                string query = $"SELECT * FROM beconfig.cta1 t0 WHERE t0.NomeCampo = '{Campo}' AND t0.idTabela = (SELECT id FROM beconfig.octa t1 WHERE t1.NomeTabela = '{Tabela}')";
                DataTableQuery dt = new DataTableQuery(query);
                Tipo(dt.Item);
            }
        }
        private void Tipo(DataTable dt)
        {
            if (dt.Rows[0]["Tipo"].ToString() == "Inteiro")
            {
                this.DefaultCellStyle.Format = "N0";
            }
            if (dt.Rows[0]["Tipo"].ToString() == "Varchar")
            {
                this.MaxInputLength = Convert.ToInt32(dt.Rows[0]["Tamanho"]);
            }
        }

    }
}
