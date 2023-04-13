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
using Essential;

namespace BusinessEssential
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            BancosDeDados db = new BancosDeDados();
            cbEmpresas.DataSource = db.BancosSistemas();
            cbEmpresas.ValueMember = "id";
            cbEmpresas.DisplayMember = "Nome";
            cbEmpresas.SelectedIndex = 0;
            if(Environment.MachineName == "DESKTOP-N6MIL1B")
            {
                txtUsuario.Text = "Manager";
                txtSenha.Text = "1234";
                //btnLogin_Click(null, null);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ConectarService conectar = new ConectarService();
                conectar.banco = Convert.ToInt32(cbEmpresas.SelectedValue);
                conectar.Usuario = txtUsuario.Text;
                conectar.Senha = txtSenha.Text;
                if (conectar.conectar())
                {
                    //MessageBox.Show("Conectado com sucesso");
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha invalido");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
