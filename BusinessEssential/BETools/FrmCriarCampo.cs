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
    public partial class FrmCriarCampo : Form
    {
        public FrmCriarCampo()
        {
            InitializeComponent();
            crud = new CRUD();
        }
        CRUD crud;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Button)sender).Text == "Adicionar")
                {
                    int cout = 1;
                    crud = new DBBE.CRUD();
                    crud.DB = DBBE.EnunDB.config;
                    var dt = crud.SelectDT($"SELECT CPid + 1 AS 'CPid' FROM cta1 WHERE idTabela = '{txtTabela.Text}' ORDER BY idTabela,CPid DESC LIMIT 1");
                    if (dt.Rows.Count > 0)
                    {
                        cout = Convert.ToInt32(dt.Rows[0][0]);
                    }
                    if (ckEstrangeira.Checked)
                    {
                        crud.Crieate("INSERT cta1 (" +
                            "idTabela,NomeCampo,PrimariKey,NTNulo,AutoI,Tipo,Tamanho,Unico,CHEstran,CPEstran,TBEstran,CPid) VALUES (" +
                            $"'{txtTabela.Text}','{txtNomaCampo.Text}',{ckPrimarykey.Checked},{ckNotnull.Checked}," +
                            $"{ckAutoIncremento.Checked},'{cbTipoCampo.Text}',{txtTamanho.Text},{ckUnico.Checked},{ckEstrangeira.Checked}," +
                            $"'{cbCPai.SelectedValue.ToString()}','{cbTabelaPai.SelectedValue.ToString()}',{cout})");
                    }
                    else
                    {
                        crud.Crieate("INSERT cta1 (" +
                            "idTabela,NomeCampo,PrimariKey,NTNulo,AutoI,Tipo,Tamanho,Unico,CHEstran,CPEstran,TBEstran,CPid) VALUES (" +
                            $"'{txtTabela.Text}','{txtNomaCampo.Text}',{ckPrimarykey.Checked},{ckNotnull.Checked}," +
                            $"{ckAutoIncremento.Checked},'{cbTipoCampo.Text}',{txtTamanho.Text},{ckUnico.Checked},{ckEstrangeira.Checked}," +
                            $"'','',{cout})");
                    }
                        
                }
                else
                {
                    if (ckEstrangeira.Checked)
                    {
                        crud.Atualizar($"update cta1 set PrimariKey = {ckPrimarykey.Checked},NTNulo = {ckNotnull.Checked}," +
                        $"AutoI = {ckAutoIncremento.Checked},Tipo = '{cbTipoCampo.Text}',Tamanho = {txtTamanho.Text},Unico = {ckUnico.Checked},CHEstran = {ckEstrangeira.Checked}" +
                        $",CPEstran = '{cbCPai.SelectedValue.ToString()}',TBEstran = '{cbTabelaPai.SelectedValue.ToString()}' where idTabela = '{txtTabela.Text}' and NomeCampo = '{txtNomaCampo.Text}'");
                    }
                    else
                    {
                        crud.Atualizar($"update cta1 set PrimariKey = {ckPrimarykey.Checked},NTNulo = {ckNotnull.Checked}," +
                        $"AutoI = {ckAutoIncremento.Checked},Tipo = '{cbTipoCampo.Text}',Tamanho = {txtTamanho.Text},Unico = {ckUnico.Checked},CHEstran = {ckEstrangeira.Checked}" +
                        $",CPEstran = '',TBEstran = '' where idTabela = '{txtTabela.Text}' and NomeCampo = '{txtNomaCampo.Text}'");
                    }
                    
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ckEstrangeira_CheckStateChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                cbTabelaPai.DataSource = crud.SelectDT("select * from octa");
                cbTabelaPai.ValueMember = "id";
                cbTabelaPai.DisplayMember = "Descricao";
                cbTabelaPai.Enabled = true;
                cbCPai.Enabled = true;
            }
            else
            {
                cbTabelaPai.DataSource = new DataTable();
                cbCPai.DataSource = new DataTable();
                cbTabelaPai.Enabled = false;
                cbCPai.Enabled = false;
            }
        }

        private void cbTabelaPai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////if(cbCPai.DataSource == DBNull.Value)
            //{
            cbCPai.DataSource = crud.SelectDT($"select * from cta1 where idTabela = '{((ComboBox)sender).SelectedValue}'");
            cbCPai.ValueMember = "NomeCampo";
            cbCPai.DisplayMember = "NomeCampo";
            //}
        }

        private void ckEstrangeira_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
