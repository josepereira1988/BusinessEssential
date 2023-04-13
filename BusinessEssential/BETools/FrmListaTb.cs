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
    public partial class FrmListaTb : Form
    {
        public FrmListaTb()
        {
            InitializeComponent();
            CRUD = new DBBE.CRUD();
            CRUD.DB = DBBE.EnunDB.config;
            pesquisarTb();
        }
        DBBE.CRUD CRUD ;

        private void pesquisarTb()
        {
            dataLista.DataSource = CRUD.SelectDT($"select * from beconfig.octa");
            dataLista.Columns["id"].HeaderText = "id";
            dataLista.Columns["id"].Width = 80;
            dataLista.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataLista.Columns["NomeTabela"].HeaderText = "Nome da Tabela";
            dataLista.Columns["NomeTabela"].Width = 150;
            dataLista.Columns["NomeTabela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataLista.Columns["Numero"].HeaderText = "Numero";
            dataLista.Columns["Numero"].Width = 80;
            dataLista.Columns["Numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataLista.Columns["Descricao"].HeaderText = "Descrição";
            dataLista.Columns["Descricao"].Width = 150;
            dataLista.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataLista.Columns["tbFilho"].HeaderText = "Filho";
            dataLista.Columns["tbFilho"].Width = 60;
            dataLista.Columns["tbFilho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataLista.Columns["TbPai"].HeaderText = "Tabela Pai";
            dataLista.Columns["TbPai"].Width = 100;
            dataLista.Columns["TBPai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataLista.Columns["DelCas"].HeaderText = "Del. Cascata";
            dataLista.Columns["DelCas"].Width = 80;
            dataLista.Columns["Delcas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataLista.Font = new Font("Calibri", 9);
            dataLista.ForeColor = Color.Black;
            dataLista.RowHeadersWidth = 25;
        }
        private void btnDois_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            FrmCriarTb frm = new FrmCriarTb();
            frm.btn1.Text = "Adicionar";
            frm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCriarTb_FormClosed);
            frm.ShowDialog();
        }
        private void FrmCriarTb_FormClosed(object sender, FormClosedEventArgs e)
        {
            pesquisarTb();
        }

        private void dataLista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCriarTb frm = new FrmCriarTb();
            frm.btn1.Text = "Atualizar";
            frm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCriarTb_FormClosed);
            frm.ShowDialog();
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            FrmListaCampo frm = new FrmListaCampo();
            //frm.btn1.Text = "Atualizar";
            frm.txtId.Text = dataLista.CurrentRow.Cells["id"].Value.ToString();
            frm.txtNomeTb.Text = dataLista.CurrentRow.Cells["NomeTabela"].Value.ToString();
            frm.txtDescricao.Text = dataLista.CurrentRow.Cells["Descricao"].Value.ToString();
            frm.txtNumero.Text = dataLista.CurrentRow.Cells["Numero"].Value.ToString();

            frm.pesquisar();
            frm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCriarTb_FormClosed);
            frm.ShowDialog();
        }
    }
}
