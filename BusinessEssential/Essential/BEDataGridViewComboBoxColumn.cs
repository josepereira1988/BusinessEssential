using ServiceBE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential
{
    public class BEDataGridViewComboBoxColumn : DataGridViewComboBoxColumn
    {
        public string display { get { return _display; } set { _display = value; config(); } }
        private string _display { get; set; }
        public string Tabela { get { return _Tabela; } set { _Tabela = value; config(); } }
        private string _Tabela { get; set; }
        public string Campo { get { return _Campo; } set { _Campo = value; config(); } }
        private string _Campo;
        private void config()
        {
            try
            {
                if (_Tabela != null && _Tabela != "" && _Campo != null && _Campo != "" && display != null && display != "")
                {
                    string query = $"SELECT *,(SELECT t1.NomeTabela FROM beconfig.octa t1 WHERE t1.Id = t0.TBEstran) as 'NomeTabela' FROM beconfig.cta1 t0 WHERE t0.NomeCampo = '{_Campo}' AND t0.idTabela = (SELECT id FROM beconfig.octa t1 WHERE t1.NomeTabela = '{_Tabela}')";

                    DataTableQuery dt = new DataTableQuery(query);
                    string query2 = $"SELECT * FROM {dt.Item.Rows[0]["NomeTabela"]} t0";
                    DataTableQuery dt2 = new DataTableQuery(query2);
                    this.DataSource = dt2.Item;
                    this.ValueMember = dt.Item.Rows[0]["CPEstran"].ToString();
                    this.DisplayMember = display;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
