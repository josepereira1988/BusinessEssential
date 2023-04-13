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
    public partial class FrmCriarTb : Form
    {
        public FrmCriarTb()
        {
            InitializeComponent();
            crud = new CRUD();
            crud.DB = EnunDB.config;
        }
        CRUD crud;
        private void btn2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ckTbFilho_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txtNTabela.Enabled = false;
                txtNTabela.Text = "";
                cbTbPai.Enabled = true;
                ckDelCas.Enabled = true;
                ckDelCas.Checked = true;
                cbTbPai.DataSource = crud.SelectDT("select * from octa");
                cbTbPai.ValueMember = "id";
                cbTbPai.DisplayMember = "Descricao";
            }
            else
            {

                cbTbPai.DataSource = new DataTable();
                txtNTabela.Enabled = true;
                cbTbPai.Enabled = false;
                ckDelCas.Enabled = false;
                ckDelCas.Checked = false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Button)sender).Text == "Adicionar")
                {
                    var dt = crud.SelectDT($"SELECT id FROM octa ORDER BY id DESC LIMIT 1");
                    int id = Convert.ToInt32(dt.Rows[0][0]) + 1;
                    string TbPai = null;
                    int numero = 0;
                    if (ckTbFilho.Checked)
                    {                        
                        TbPai = Convert.ToString(cbTbPai.SelectedValue);
                        dt = crud.SelectDT($"select count(1) as 'Numero' FROM octa where NomeTabela = (SELECT NomeTabela FROM octa WHERE id = '{cbTbPai.SelectedValue}')");
                        numero = Convert.ToInt32(dt.Rows[0][0]) + 1;
                    }
                    string query = $"INSERT  beconfig.OCTA (id,NomeTabela,Numero,Descricao,TbFilho,TbPai,DelCas) VALUES ('{id}','{txtNTabela.Text}','{numero}','{txtDescri.Text}',{ckTbFilho.Checked},'{TbPai}',{ckDelCas.Checked});";
                    crud.Crieate(query);
                    Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
