using BusinessEssential.Modulos.Administracao.Configuação;
using BusinessEssential.Modulos.Administracao.Usuarios;
using Essential;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessEssential
{
    public partial class FrmInicical : Frm
    {
        FrmLogin Login;
        public FrmInicical()
        {
            InitializeComponent();
            FrmControle.oformInicial = (Frm)this;
            //if (Environment.MachineName != "DESKTOP-N6MIL1B")
            //{                
                MSIncical.Enabled = false;
                Login = new FrmLogin();
                Login.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
                Login.MdiParent = this;
                Login.Show();
            //}
            TSInicial.Enabled = false;
        }
        public void AtivarTBS()
        {
            TSInicial.Enabled = true;
        }
        public void DesativarTBS()
        {
            TSInicial.Enabled = false;
        }
        private void TSBPrimeiro_Click(object sender, EventArgs e)
        {
            if (FrmControle.oform.Name != this.Name)
            {
                var method = FrmControle.oform.GetType().GetMethod("TSBPrimeiro_Click");
                string nome = FrmControle.oform.Name;
                method.Invoke(FrmControle.oform, parameters: null);
            }
        }
        private void TSBVoltar_Click(object sender, EventArgs e)
        {
            if (FrmControle.oform.Name != this.Name)
            {
                var method = FrmControle.oform.GetType().GetMethod("TSBVoltar_Click");
                method.Invoke(FrmControle.oform, parameters: null);
            }
        }
        private void TSBProximo_Click(object sender, EventArgs e)
        {
            if (FrmControle.oform.Name != this.Name)
            {
                var method = FrmControle.oform.GetType().GetMethod("TSBProximo_Click");
                method.Invoke(FrmControle.oform, parameters: null);
            }
        }
        private void TSBUltimo_Click(object sender, EventArgs e)
        {
            if (FrmControle.oform.Name != this.Name)
            {
                var method = FrmControle.oform.GetType().GetMethod("TSBUltimo_Click");
                method.Invoke(FrmControle.oform, parameters: null);
            }
        }
        private void TSBNovo_Click(object sender, EventArgs e)
        {
            if (FrmControle.oform.Name != this.Name)
            {
                var method = FrmControle.oform.GetType().GetMethod("TSBNovo_Click");
                method.Invoke(FrmControle.oform, parameters: null);
            }
        }
        private void TSBPesquisar_Click(object sender, EventArgs e)
        {
            if (FrmControle.oform.Name != this.Name)
            {
                var method = FrmControle.oform.GetType().GetMethod("TSBPesquisar_Click");
                method.Invoke(FrmControle.oform, parameters: null);
            }
        }
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Login.DialogResult == DialogResult.OK)
                MSIncical.Enabled = true;
        }
        public void FrmExecutar(object sender, EventArgs e,Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmExecutar(sender, e, new FrmUsuarios());
        }

        private void cadastroEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExecutar(sender, e, new FrmCadastroEmpresa());
        }
    }
}
