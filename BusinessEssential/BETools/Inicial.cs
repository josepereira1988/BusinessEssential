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
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void btnInicial_Click(object sender, EventArgs e)
        {
            FrmConfigurar form1 = new FrmConfigurar();
            form1.txtNomeBanco.Text = "BEConfig";
            form1.txtNomeBanco.ReadOnly = true;
            form1.txtNome.ReadOnly = true;
            form1.txtNome.Text = "Config";
            form1.ShowDialog();
        }

        private void btnCriarBanco_Click(object sender, EventArgs e)
        {
            FrmCriarBanco form1 = new FrmCriarBanco();
            form1.txtNomeBanco.Text = "";
            form1.txtNomeBanco.ReadOnly = false;
            form1.txtCNPJ.ReadOnly = false;
            form1.txtCNPJ.Text = "";
            form1.txtRSocial.ReadOnly = false;
            form1.txtRSocial.Text = "";
            form1.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            FrmLoginDB form1 = new FrmLoginDB();
            form1.ShowDialog();
        }

        private void btnCriarTb_Click(object sender, EventArgs e)
        {
            FrmListaTb frm = new FrmListaTb();
            frm.ShowDialog();
        }

        private void btnAtualizarDB_Click(object sender, EventArgs e)
        {
            FrmAtualizarDB frm = new FrmAtualizarDB();
            frm.Show();
        }
    }
}
