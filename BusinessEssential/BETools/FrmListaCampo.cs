using DBBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BETools
{
    public partial class FrmListaCampo : Form
    {
        public FrmListaCampo()
        {
            InitializeComponent();
            crue = new CRUD();
            crue.DB = EnunDB.config;
        }
        CRUD crue;
        //private string _tabela;
        public void pesquisar()
        {
            crue = new CRUD();
            crue.DB = EnunDB.config;
            //_tabela = tabela;
            dataLista.DataSource = crue.SelectDT($"Select * from beconfig.cta1 where idTabela = '{txtId.Text}' ORDER BY idTabela,CPid asc");

            dataLista.Columns[0].HeaderText = "id da Tabela";
            dataLista.Columns[0].Width = 100;
            dataLista.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataLista.Columns[0].Visible = false;

            dataLista.Columns[1].HeaderText = "Nome do Campo";
            dataLista.Columns[1].Width = 150;
            dataLista.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataLista.Columns[2].HeaderText = "Chave";
            dataLista.Columns[2].Width = 60;
            dataLista.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataLista.Columns[2].ValueType = typeof(bool);  
            
            dataLista.Columns[3].HeaderText = "Nulo";
            dataLista.Columns[3].Width = 60;
            dataLista.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataLista.Columns[3].ValueType = typeof(bool);

            dataLista.Columns[4].HeaderText = "Auto.In";
            dataLista.Columns[4].Width = 80;
            dataLista.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataLista.Columns[4].ValueType = typeof(bool);

            dataLista.Columns[5].HeaderText = "Tipo";
            dataLista.Columns[5].Width = 100;
            dataLista.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataLista.Columns[6].HeaderText = "Tamanho";
            dataLista.Columns[6].Width = 80;
            dataLista.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataLista.Columns[7].HeaderText = "Unico";
            dataLista.Columns[7].Width = 60;
            dataLista.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataLista.Columns[7].ValueType = typeof(bool);

            dataLista.Columns[8].HeaderText = "Chave.Est";
            dataLista.Columns[8].Width = 80;
            dataLista.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataLista.Columns[8].ValueType = typeof(bool);

            dataLista.Columns[9].HeaderText = "Campo.Est";
            dataLista.Columns[9].Width = 100;
            dataLista.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataLista.Columns[10].HeaderText = "Tabela.Est";
            dataLista.Columns[10].Width = 100;
            dataLista.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            

            dataLista.ForeColor = Color.Black;
            dataLista.RowHeadersWidth = 25;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCriarCampo frm = new FrmCriarCampo();
            frm.btnAdd.Text = "Adicionar";
            frm.txtTabela.Text = txtId.Text;
            frm.ShowDialog();
            pesquisar();
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCriarCampo frm = new FrmCriarCampo();
            frm.btnAdd.Text = "Atualizar";
            frm.txtTabela.Text = dataLista.CurrentRow.Cells["idTabela"].Value.ToString();
            frm.txtNomaCampo.Text = dataLista.CurrentRow.Cells["NomeCampo"].Value.ToString();
            frm.ckPrimarykey.Checked = Convert.ToBoolean(dataLista.CurrentRow.Cells["PrimariKey"].Value);
            frm.ckNotnull.Checked = Convert.ToBoolean(dataLista.CurrentRow.Cells["NTNulo"].Value.ToString());
            frm.ckAutoIncremento.Checked = Convert.ToBoolean(dataLista.CurrentRow.Cells["AutoI"].Value);
            frm.cbTipoCampo.Text = Convert.ToString(dataLista.CurrentRow.Cells["Tipo"].Value);
            frm.txtTamanho.Text = Convert.ToString(dataLista.CurrentRow.Cells["Tamanho"].Value);
            frm.ckUnico.Checked = Convert.ToBoolean(dataLista.CurrentRow.Cells["Unico"].Value.ToString());
            frm.ckEstrangeira.Checked = Convert.ToBoolean(dataLista.CurrentRow.Cells["CHEstran"].Value);
            if (frm.ckEstrangeira.Checked)
            {
                frm.cbTabelaPai.SelectedValue = Convert.ToString(dataLista.CurrentRow.Cells["TBEstran"].Value);
                frm.cbCPai.SelectedValue = Convert.ToString(dataLista.CurrentRow.Cells["CPEstran"].Value);
            }                        
            frm.ShowDialog();
            pesquisar();
        }
    }
}
