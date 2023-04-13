using BasesBE;
using Essential;
using ServiceBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessEssential.Modulos.Administracao.Configuação
{
    public partial class FrmCadastroEmpresa : FrmBase
    {
        public FrmCadastroEmpresa()
        {
            InitializeComponent();
            this.sform = Statusforms.OK;
            //this.bform = BtnIniciar.Sim;
            BEDCID.Campo = "id";
            BEDCID.Tabela = "becadastro";

            BEDCRazaoSocial.Campo = "RazaoSocia";
            BEDCRazaoSocial.Tabela = "becadastro";

            BEDCNFantasia.Campo = "NFantasia";
            BEDCNFantasia.Tabela = "becadastro";

            BEDCCNPJ.Campo = "CNPJ";
            BEDCCNPJ.Tabela = "becadastro";

            BEDCLogarouro.Campo = "Logadouro";
            BEDCLogarouro.Tabela = "becadastro";

            BEDCNumero.Campo = "Logadouro";
            BEDCNumero.Tabela = "becadastro";

            BEDCLogarouro.Campo = "Complement";
            BEDCLogarouro.Tabela = "becadastro";

            BEDCLogarouro.Campo = "CEP";
            BEDCLogarouro.Tabela = "becadastro";
            //DataLista.ConfigureGrid();           
            DataLista.Numerar();
        }

        private void DataLista_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (((BEDataGridViewTextBoxColumn)((BEDataGridView)sender).Columns[e.ColumnIndex]).Campo == "CNPJ")
                {
                    if (Essential.FormatCNPJCPF.SemFormatacao(((BEDataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()).Length == 14)
                        ((BEDataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Essential.FormatCNPJCPF.FormatCNPJ(((BEDataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }

            }
            catch (Exception)
            {

                //throw;
            }
        }
        private void DataLista_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (((BEDataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (value != ((BEDataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
                    {
                        if (((BEDataGridView)sender).Columns[e.ColumnIndex].GetType() == typeof(BEDataGridViewTextBoxColumn))
                        {
                            if (((BEDataGridViewTextBoxColumn)((BEDataGridView)sender).Columns[e.ColumnIndex]).Campo == "CNPJ")
                            {
                                string verificador = Essential.FormatCNPJCPF.SemFormatacao(((DataGridViewCell)DataLista.Rows[e.RowIndex].Cells[e.ColumnIndex]).Value.ToString());
                                if (verificador.Length != 14)
                                {
                                    MessageBox.Show("CNPJ invalido");
                                    ((BEDataGridView)sender).CurrentCell = ((BEDataGridView)sender)[e.ColumnIndex, e.RowIndex];
                                }
                                else
                                {
                                    ConsultarCNPJ cnpj = new ConsultarCNPJ();
                                    var resultado = cnpj.Consultar(((BEDataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                                    ((BEDataGridView)sender).Rows[e.RowIndex].Cells["BEDCRazaoSocial"].Value = resultado.RazaoSocial;
                                    ((BEDataGridView)sender).Rows[e.RowIndex].Cells["BEDCNFantasia"].Value = resultado.NomeFantasia;
                                    ((BEDataGridView)sender).Rows[e.RowIndex].Cells["BEDCCEP"].Value = resultado.EnderecoCEP.Replace(".", "");
                                    ((BEDataGridView)sender).Rows[e.RowIndex].Cells["BEDCNumero"].Value = resultado.EnderecoNumero;
                                    //((BEDataGridView)sender).Rows[e.RowIndex].Cells["BEDCLogadouro"].Value = resultado.EnderecoLogradouro;
                                    ((BEDataGridView)sender).Rows[e.RowIndex].Cells["BEDCComplemento"].Value = resultado.EnderecoLogradouro;
                                    //((BEDataGridView)sender).Rows[e.RowIndex].Cells["BEDCBairro"].Value = resultado.EnderecoLogradouro;
                                }
                            }
                        }
                        if (((BEDataGridView)sender).Columns[e.ColumnIndex].GetType() == typeof(BEDataGridViewComboBoxColumn))
                        {
                            if (((BEDataGridViewComboBoxColumn)((BEDataGridView)sender).Columns[e.ColumnIndex]).Campo.ToLower() == "idEstado".ToLower())
                            {
                                if (((BEDataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                                {
                                    string query = $"select '0' as 'id','' as 'Nome' union all SELECT T0.id,t0.Nome from bemunicipi t0 where t0.idEstado = {((BEDataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value}";
                                    DataTableQuery dt2 = new DataTableQuery(query);
                                    ((DataGridViewComboBoxCell)((BEDataGridView)sender).Rows[e.RowIndex].Cells["BEDCidMunicipi"]).DataSource = dt2.Item;
                                    ((DataGridViewComboBoxCell)((BEDataGridView)sender).Rows[e.RowIndex].Cells["BEDCidMunicipi"]).ValueMember = "id";
                                    ((DataGridViewComboBoxCell)((BEDataGridView)sender).Rows[e.RowIndex].Cells["BEDCidMunicipi"]).DisplayMember = "Nome";
                                    ((DataGridViewComboBoxCell)((BEDataGridView)sender).Rows[e.RowIndex].Cells["BEDCidMunicipi"]).Value = "0";
                                }
                            }
                        }                            
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private string value;

        private void DataLista_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (((BEDataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //if(((BEDataGridView)sender).Columns.GetType() == typeof(BEDataGridViewTextBoxColumn))
                value = DataLista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
            else
            {
                value = "";
            }
        }
    }
}
