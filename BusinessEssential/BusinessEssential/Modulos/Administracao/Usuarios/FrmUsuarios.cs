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

namespace BusinessEssential.Modulos.Administracao.Usuarios
{
    public partial class FrmUsuarios : FrmBase
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            //this.bform = BtnIniciar.Sim;
            //FrmControle.Incial(this);
           
        }
        Essential.FrmOGrid frm;
        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sform == Statusforms.OK)
                {
                    Close();
                }
                if (sform == Statusforms.Procurar)
                {
                    var usuario = Pegar();
                    string query = $"select * from beusers ";
                    if (txtID.Text.Length > 0)
                    {
                        query += $"where id = {txtID.Text};";
                    }
                    else
                    {
                        query += BeMontaSelect.Queryable(this) + ";";
                    }

                    var dt = new ServiceBE.DataTableQuery(query);

                    if (dt.Item.Rows.Count > 0)
                    {
                        if (dt.Item.Rows.Count == 1)
                        {

                            usuario = new UsuariosService();
                            usuario.GetKey(Convert.ToInt32(dt.Item.Rows[0][0].ToString()));
                            var a = CriarBeEntity(usuario, "BEUsers");
                            achou(a);
                        }
                        else
                        {
                            frm = new Essential.FrmOGrid();
                            frm.MdiParent = this.MdiParent;
                            frm.dataList.DataSource = dt.Item;
                            frm.Text = "Lista de Usuarios";
                            frm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_FormClosed);
                            frm.Show();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro localizado");
                        return;
                    }


                }
                if (sform == Statusforms.Adicionar)
                {
                    var usuario = Pegar();
                    usuario.add();
                    txtID.Text = usuario.Id.ToString();
                }
                if (sform == Statusforms.Atualizar)
                {
                    var usuario = Pegar();
                    usuario.autalizar();
                }
                sform = Statusforms.OK;
                MStatus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #region BTN
        public void TSBNovo_Click()
        {
            try
            {
                sform = Statusforms.Adicionar;
                txtID.ReadOnly = true;
                pesquisar_novo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void TSBPesquisar_Click()
        {
            try
            {
                sform = Statusforms.Procurar;
                txtID.ReadOnly = false;
                pesquisar_novo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void TSBVoltar_Click()
        {
            try
            {
                ServiceBE.UsuariosService usuarios = new ServiceBE.UsuariosService();
                if (txtID.Text == "" || Convert.ToInt32(txtID.Text) == 1)
                {
                    usuarios.PrimeioRegistro();
                }
                else
                {
                    int controle = 0;
                    for (int i = Convert.ToInt32(txtID.Text) - 1; controle < 1; i--)
                    {
                        if (i <= 0)
                        {
                            break;
                        }
                        controle = usuarios.GetKey(i);
                    }
                }

                if (usuarios.Id > 0)
                {
                    sform = Statusforms.OK;
                    var a = CriarBeEntity(usuarios, "BEUsers");
                    achou(a);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void TSBProximo_Click()
        {
            try
            {
                ServiceBE.UsuariosService usuarios = new ServiceBE.UsuariosService();
                usuarios.UltimoRegistro();
                if (txtID.Text != "")
                {
                    if (usuarios.Id != Convert.ToInt32(txtID.Text))
                    {

                        usuarios.Id = 0;
                        //usuarios.GetKey(Convert.ToInt32(txtID.Text) + 1);
                        int controle = 0;
                        for (int i = Convert.ToInt32(txtID.Text) + 1; controle < 1; i++)
                        {
                            if (i <= 0)
                            {
                                break;
                            }
                            controle = usuarios.GetKey(i);
                        }
                    }
                    else
                    {

                    }
                }

                if (usuarios.Id > 0)
                {
                    sform = Statusforms.OK;
                    var a = CriarBeEntity(usuarios, "BEUsers");
                    achou(a);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void TSBUltimo_Click()
        {
            try
            {
                ServiceBE.UsuariosService usuarios = new ServiceBE.UsuariosService();
                usuarios.UltimoRegistro();

                if (usuarios.Id > 0)
                {
                    sform = Statusforms.OK;
                    var a = CriarBeEntity(usuarios, "BEUsers");
                    achou(a);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public UsuariosService Pegar()
        {

            UsuariosService usuarios = new UsuariosService();
            if (txtID.Text != "")
                usuarios.Id = Convert.ToInt32(txtID.Text);
            usuarios.Usuario = txtUsuario.Text;
            usuarios.Nome = txtNome.Text;
            usuarios.Senha = txtSenha.Text;
            usuarios.Ativo = rbAtivo.Checked;
            usuarios.Inativo = rbInativo.Checked;
            return usuarios;
        }
        public void pesquisar_novo()
        {
            txtUsuario.ReadOnly = false;
        }

        #endregion

        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(frm.DialogResult == DialogResult.OK)
            {
                var usuario = new UsuariosService();
                usuario.GetKey(Convert.ToInt32(frm.dataList.CurrentRow.Cells[0].Value));
                var a = CriarBeEntity(usuario, "BEUsers");
                achou(a);
            }
        }


    }
}
